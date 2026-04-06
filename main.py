# main.py
import argparse
from scanner import mode_manual, mode_scan

if __name__ == '__main__':
    parser = argparse.ArgumentParser(description="TETRA Signal Detector (Spectrum Heuristic)")
    parser.add_argument('-m', '--manual', type=float, help='Center frequency in MHz for manual mode (live plot)')
    parser.add_argument('-s', '--scan', nargs=2, type=float, metavar=('START_MHZ', 'STOP_MHZ'), help='Start and stop frequencies in MHz for blind scan')
    
    args = parser.parse_args()
    
    if args.manual:
        mode_manual(args.manual)
    elif args.scan:
        mode_scan(args.scan[0], args.scan[1])
    else:
        parser.print_help()