using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tetra_hunter_WindowsGUI {
    public partial class debugSpectrum_forms : Form {
        public event Action<int[]> AoEnviarDadosDeTeste;
        private Random rnd = new Random();
        public debugSpectrum_forms() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int[] dadosFalsos = new int[100];
            for (int i = 0; i < dadosFalsos.Length; i++) {
                dadosFalsos[i] = rnd.Next(10, 250);
            } AoEnviarDadosDeTeste?.Invoke(dadosFalsos);
        }
    }
}
