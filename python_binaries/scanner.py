# scanner.py
import time
import matplotlib.pyplot as plt
import matplotlib.animation as animation
from rtlsdr import RtlSdr
from config import SAMPLE_RATE
from dsp import get_psd, detect_tetra

# open a live spectrum view for a specific frequency
def mode_manual(freq_mhz):
    center_freq = freq_mhz * 1e6
    sdr = RtlSdr()
    sdr.sample_rate = SAMPLE_RATE
    sdr.center_freq = center_freq
    sdr.gain = 'auto'

    fig, ax = plt.subplots(figsize=(10, 6))
    
    def update(frame):
        ax.clear()
        freqs, psd_db = get_psd(sdr)
        real_freqs = (center_freq + freqs) / 1e6 # convert x-axis to MHz
        
        ax.plot(real_freqs, psd_db, color='blue')
        ax.set_title(f'Live Spectrum (Center: {freq_mhz} MHz) - Scanning TETRA')
        ax.set_xlabel('Frequency (MHz)')
        ax.set_ylabel('Power (dB)')
        ax.set_ylim([-90, 10])
        ax.grid(True)

        # detect and highlight TETRA signals
        tetra_signals = detect_tetra(freqs, psd_db, center_freq)
        for tfreq, tpower, tbw in tetra_signals:
            tfreq_mhz = tfreq / 1e6
            ax.plot(tfreq_mhz, tpower, 'ro') # red marker on peak
            ax.axvspan(tfreq_mhz - (tbw/2/1e6), tfreq_mhz + (tbw/2/1e6), color='green', alpha=0.3)
            ax.text(tfreq_mhz, tpower + 2, f'TETRA\n{tfreq_mhz:.4f}', ha='center', fontsize=9, color='green')

    print(f"[*] Starting live monitoring at {freq_mhz} MHz. Close the window to exit.")
    ani = animation.FuncAnimation(fig, update, interval=200, cache_frame_data=False)
    plt.show()
    
    sdr.close()

def mode_scan(start_mhz, stop_mhz):
    # run a blind scan and log detected TETRA frequencies
    sdr = RtlSdr()
    sdr.sample_rate = SAMPLE_RATE
    sdr.gain = 'auto'
    
    # use overlapping scan steps for safer coverage
    step_hz = SAMPLE_RATE * 0.8 
    current_freq = start_mhz * 1e6
    stop_freq = stop_mhz * 1e6
    
    log_file = "tetra_log.txt"
    print(f"[*] Starting scan from {start_mhz} MHz to {stop_mhz} MHz...")
    print(f"[*] Results will be saved to: {log_file}")
    
    with open(log_file, "a") as f:
        f.write(f"\n--- New Scan: {time.strftime('%Y-%m-%d %H:%M:%S')} ---\n")
        
        while current_freq <= stop_freq:
            print(f"[*] Analyzing block centered at {current_freq / 1e6:.3f} MHz...")
            sdr.center_freq = current_freq
            time.sleep(0.1) # allow hardware tuner to stabilize
            
            freqs, psd_db = get_psd(sdr)
            tetra_signals = detect_tetra(freqs, psd_db, current_freq)
            
            for tfreq, tpower, tbw in tetra_signals:
                msg = f"[+] TETRA detected: {tfreq / 1e6:.4f} MHz | Power: {tpower:.1f} dB | BW: {tbw/1000:.1f} kHz"
                print(msg)
                f.write(msg + "\n")
                
            current_freq += step_hz

    sdr.close()
    print("[*] Scan completed.")