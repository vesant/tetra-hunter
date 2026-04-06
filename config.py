# global config
SAMPLE_RATE = 1.024e6  # 1.024 MHz usualy used for TETRA
NFFT = 2048            # fft
BIN_HZ = SAMPLE_RATE / NFFT

# TETRA uses 25kHz channels, +/- peek -10dB usualy 18kHz - 22kHz bandwidth
TETRA_MIN_BW_HZ = 16000 
TETRA_MAX_BW_HZ = 24000
SIGNAL_THRESHOLD_DB = 15 # dB threshold 