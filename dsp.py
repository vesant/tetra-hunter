# dsp.py
import numpy as np
from scipy.signal import find_peaks, welch
from config import SAMPLE_RATE, NFFT, BIN_HZ, TETRA_MIN_BW_HZ, TETRA_MAX_BW_HZ, SIGNAL_THRESHOLD_DB

# calculate power spectral density (PSD)
def get_psd(sdr):
    # Discard initial samples so the SDR can stabilize
    sdr.read_samples(1024) 
    samples = sdr.read_samples(256 * 1024)
    
    # use Welch PSD for a cleaner spectrum
    freqs, psd = welch(samples, fs=SAMPLE_RATE, nperseg=NFFT, return_onesided=False, scaling='spectrum')
    
    # reorder FFT bins
    freqs = np.fft.fftshift(freqs)
    psd = np.fft.fftshift(psd)
    
    # convert to dB
    psd_db = 10 * np.log10(psd + 1e-12)
    return freqs, psd_db

def detect_tetra(freqs, psd_db, center_freq):
    # find peaks and filter by typical TETRA bandwidth
    noise_floor = np.median(psd_db)
    threshold = noise_floor + SIGNAL_THRESHOLD_DB
    
    # find peaks above the noise floor
    peaks, properties = find_peaks(psd_db, height=threshold, width=1)
    
    tetra_signals = []
    
    for i, peak_idx in enumerate(peaks):
        # width is measured in FFT bins, use the half-height estimate...
        width_bins = properties['widths'][i]
        width_hz = width_bins * BIN_HZ
        
        # keep only signals that match the TETRA bandwidth range
        if TETRA_MIN_BW_HZ <= width_hz <= TETRA_MAX_BW_HZ:
            actual_freq = center_freq + freqs[peak_idx]
            tetra_signals.append((actual_freq, psd_db[peak_idx], width_hz))
            
    return tetra_signals