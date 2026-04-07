#!/bin/bash
# This script makes the tetra-hunter application executable after building.

# Check if the application file exists
if [ -f "dist/tetra-hunter/tetra-hunter" ]; then
    echo "Making tetra-hunter executable..."
    chmod +x dist/tetra-hunter/tetra-hunter
    echo "Done. You can now run the application from the 'dist/tetra-hunter' directory."
else
    echo "Error: Application not found at 'dist/tetra-hunter/tetra-hunter'."
    echo "Please build the project with PyInstaller first."
    exit 1
fi
