# TETRA Signal Hunter (Windows)

Welcome to the TETRA Signal Hunter project. This Windows build targets radio frequency (RF) enthusiasts and researchers who want to locate Terrestrial Trunked Radio (TETRA) signals in the wild using an RTL-SDR dongle on Windows.

It is designed strictly as a spectrum analysis tool. It looks for the visual and spectral "fingerprint" of a TETRA signal to identify active frequencies. It does not extract data, capture audio, or attempt any form of decryption. 

## What is TETRA?

TETRA stands for Terrestrial Trunked Radio. It is a professional mobile radio specification widely used worldwide by government agencies, emergency services (police, fire, ambulance), public transport networks, and military entities. 

Unlike standard analog radio, TETRA is highly digital and often encrypted. From a radio frequency perspective, TETRA uses a modulation scheme called pi/4-DQPSK and operates on channels with a 25 kHz spacing. When you look at a TETRA continuous control channel on a spectrum analyzer, it appears as a distinct, flat-topped block that spans roughly 18 to 22 kHz in bandwidth. 

Because of this very specific shape and width, we can use mathematical heuristics to find these signals in the radio spectrum without ever needing to decode the underlying digital protocol.

## How This Tool Works

This app reads raw RF samples from an RTL-SDR and calculates the Power Spectral Density (PSD). It establishes a noise floor and looks for signal peaks. When it finds a peak, it measures the width of the signal at its base. If the signal width falls between 16 kHz and 24 kHz (our heuristic threshold for a TETRA channel), the app flags it as a probable TETRA signal.

### Features

* **Manual Mode (Real-Time UI):** Enter a specific center frequency. The Windows GUI opens a live spectrum graph and draws green markers over any signal that matches the TETRA bandwidth profile.
* **Scan Mode (Blind Sweeping):** Set a start and stop frequency. The scanner steps through the spectrum, analyzes it, and logs the exact frequencies of any detected TETRA signals into a text file (`tetra_log.txt`).

You can check [example.png](example.png) to see how the graphical interface looks.

## Prerequisites (Windows)

You will need a Windows PC, an RTL-SDR USB dongle, and the correct driver for SDR access.

1. Install an RTL-SDR driver with Zadig (WinUSB). There are many guides online; any standard RTL-SDR Zadig install procedure works.
2. If you are running the Python build, install Python 3.10+ and then:
```bash
pip install -r python_binaries\requirements.txt
```

## Usage (Windows)

### Windows GUI (recommended)

Open the Visual Studio solution at `tetra-hunter_WindowsGUI/tetra-hunter_WindowsGUI.slnx`, build the project, then run the app.

### Python CLI (optional)

If you prefer the CLI tools, run the Python version from the `python_binaries` folder.

**Manual Mode (Live Graph):**
Replace `420.0` with your target frequency in MHz.
```bash
python python_binaries\main.py -m 420.0
```

**Scan Mode (Background Sweeping):**
Replace the two numbers with your desired start and stop frequencies in MHz.
```bash
python python_binaries\main.py -s 410.0 430.0
```

## Technical Limitations

Please keep in mind that this tool relies on a heuristic approach (shape and bandwidth detection). It does not demodulate the signal to verify the bitstream. Therefore, it is entirely possible to encounter false positives. Any continuous wideband interference or digital signal that happens to be roughly 20 kHz wide might be mistakenly flagged as TETRA. For absolute certainty, a full software-defined radio decoder chain would be necessary, but this script serves as an excellent, lightweight reconnaissance tool to narrow down where you should be looking.

## Legal Notice

**Disclaimer:** This software is provided for educational and spectrum analysis purposes only. 

While this script only performs basic mathematical analysis of radio frequency bandwidths and does not decode, demodulate, intercept, or decrypt any communications, the laws regarding radio spectrum monitoring vary significantly by country and jurisdiction. 

You are solely responsible for ensuring that your use of this software and any SDR hardware complies with all local, state, and federal telecommunications laws. The author assumes no liability for any misuse of this tool or any legal repercussions that may arise from unauthorized spectrum monitoring.
