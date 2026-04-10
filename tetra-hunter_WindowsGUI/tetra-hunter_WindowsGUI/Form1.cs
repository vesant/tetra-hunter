using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // For Process.Start
using System.IO;
using Newtonsoft.Json;

namespace tetra_hunter_WindowsGUI {
    public partial class Form1 : Form {
        private debugSpectrum_forms painelDebug;
        private autoSearch_forms autoSearch;
        public Form1() {
            InitializeComponent();
            this.ControlBox = false;
            pictureBox1.BringToFront();
        }

        private async void Form1_Load(object sender, EventArgs e) {
            closeAll_GroupBoxes();
            await webView21.EnsureCoreWebView2Async(null); // make sure WebView2 initializes
            string pastaDaApp = System.Windows.Forms.Application.StartupPath;

            // load index.html
            string webFile_patch = System.IO.Path.Combine(pastaDaApp, @"webApp\index.html");

            webView21.CoreWebView2.Navigate(webFile_patch);

        }

        // Função para enviar os dados. Podes chamá-la sempre que tiveres um frame novo.
        public async void EnviarDadosParaOSpectrum(int[] dadosFft) {
            // make sure WebView2 is initialized before trying to execute scripts
            if (webView21.CoreWebView2 != null) {
                // Convert c# array to JSON string
                string dadosJson = JsonConvert.SerializeObject(dadosFft);
                string scriptJs = $"atualizarSpectrum({dadosJson});";

                // executes script
                await webView21.CoreWebView2.ExecuteScriptAsync(scriptJs);
            }
        }

        // button to exit program
        private void pictureBox1_Click(object sender, EventArgs e) {
            Close();
        }

        private void openFromToolStripMenuItem_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Title = "Select a file to open in Notepad";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    string filePath = openFileDialog.FileName;

                    // Validate file existence
                    if (File.Exists(filePath)) {
                        try {
                            Process.Start(new ProcessStartInfo {
                                FileName = "notepad.exe",
                                Arguments = $"\"{filePath}\"",
                                UseShellExecute = true
                            });
                        } catch (Exception ex) {
                            MessageBox.Show($"Error opening file in Notepad:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else {
                        MessageBox.Show("The selected file does not exist.",
                            "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e) {
            string logPath = @"logs\tetra_log.txt";

            void lauchDialog() {

                if (!System.IO.File.Exists(logPath)) {
                    MessageBox.Show("Log file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else {
                    Process.Start("notepad.exe", logPath);
                }
            }
            lauchDialog();
        }

        private void openDebuggerWindowToolStripMenuItem_Click(object sender, EventArgs e) {
            if (painelDebug == null || painelDebug.IsDisposed) {
                painelDebug = new debugSpectrum_forms();

                painelDebug.AoEnviarDadosDeTeste += ReceberDadosDoDebug;

                painelDebug.Show();
            } else {
                painelDebug.BringToFront();
            }
        }

        private async void ReceberDadosDoDebug(int[] dadosFft) {
            if (webView21 != null && webView21.CoreWebView2 != null) {
                string dadosJson = JsonConvert.SerializeObject(dadosFft); // convert to json

                string scriptJs = $"atualizarSpectrum({dadosJson});";
                await webView21.CoreWebView2.ExecuteScriptAsync(scriptJs);
            }
        }

        private void openSpectrumToolStripMenuItem_Click(object sender, EventArgs e) {
            groupBox_spectrum.Show();
        }

        void closeAll_GroupBoxes() {
            groupBox_spectrum.Hide();
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e) {
            if (autoSearch == null || autoSearch.IsDisposed) {
                autoSearch= new autoSearch_forms();
                autoSearch.Show();
            } else {
                autoSearch.BringToFront();
            }
        }
    }
}