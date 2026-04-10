namespace tetra_hunter_WindowsGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spectrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSpectrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugueseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_spectrum = new System.Windows.Forms.GroupBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugSpectrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDebuggerWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_freq = new System.Windows.Forms.TextBox();
            this.button_analisar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.groupBox_spectrum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modesToolStripMenuItem,
            this.openLogsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(118, 38);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.spectrumToolStripMenuItem});
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.modesToolStripMenuItem.Text = "Modes";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.autoToolStripMenuItem.Text = "Auto";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // spectrumToolStripMenuItem
            // 
            this.spectrumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSpectrumToolStripMenuItem});
            this.spectrumToolStripMenuItem.Name = "spectrumToolStripMenuItem";
            this.spectrumToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.spectrumToolStripMenuItem.Text = "Spectrum";
            // 
            // openSpectrumToolStripMenuItem
            // 
            this.openSpectrumToolStripMenuItem.Name = "openSpectrumToolStripMenuItem";
            this.openSpectrumToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.openSpectrumToolStripMenuItem.Text = "Open Spectrum";
            this.openSpectrumToolStripMenuItem.Click += new System.EventHandler(this.openSpectrumToolStripMenuItem_Click);
            // 
            // openLogsToolStripMenuItem
            // 
            this.openLogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.openFromToolStripMenuItem});
            this.openLogsToolStripMenuItem.Name = "openLogsToolStripMenuItem";
            this.openLogsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.openLogsToolStripMenuItem.Text = "Open Logs";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // openFromToolStripMenuItem
            // 
            this.openFromToolStripMenuItem.Name = "openFromToolStripMenuItem";
            this.openFromToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
            this.openFromToolStripMenuItem.Text = "Open from...";
            this.openFromToolStripMenuItem.Click += new System.EventHandler(this.openFromToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(158, 38);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.portugueseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(251, 44);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(267, 44);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // portugueseToolStripMenuItem
            // 
            this.portugueseToolStripMenuItem.Name = "portugueseToolStripMenuItem";
            this.portugueseToolStripMenuItem.Size = new System.Drawing.Size(267, 44);
            this.portugueseToolStripMenuItem.Text = "Portuguese";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemDefaultToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.blackToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(251, 44);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // systemDefaultToolStripMenuItem
            // 
            this.systemDefaultToolStripMenuItem.Name = "systemDefaultToolStripMenuItem";
            this.systemDefaultToolStripMenuItem.Size = new System.Drawing.Size(308, 44);
            this.systemDefaultToolStripMenuItem.Text = "System Default";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(308, 44);
            this.whiteToolStripMenuItem.Text = "White";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(308, 44);
            this.blackToolStripMenuItem.Text = "Black";
            // 
            // groupBox_spectrum
            // 
            this.groupBox_spectrum.Controls.Add(this.button_analisar);
            this.groupBox_spectrum.Controls.Add(this.textBox_freq);
            this.groupBox_spectrum.Controls.Add(this.label1);
            this.groupBox_spectrum.Controls.Add(this.webView21);
            this.groupBox_spectrum.Location = new System.Drawing.Point(12, 43);
            this.groupBox_spectrum.Name = "groupBox_spectrum";
            this.groupBox_spectrum.Size = new System.Drawing.Size(991, 667);
            this.groupBox_spectrum.TabIndex = 2;
            this.groupBox_spectrum.TabStop = false;
            this.groupBox_spectrum.Text = "Spectrum";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(6, 291);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(979, 370);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugSpectrumToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // debugSpectrumToolStripMenuItem
            // 
            this.debugSpectrumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDebuggerWindowToolStripMenuItem});
            this.debugSpectrumToolStripMenuItem.Name = "debugSpectrumToolStripMenuItem";
            this.debugSpectrumToolStripMenuItem.Size = new System.Drawing.Size(328, 44);
            this.debugSpectrumToolStripMenuItem.Text = "Debug Spectrum";
            // 
            // openDebuggerWindowToolStripMenuItem
            // 
            this.openDebuggerWindowToolStripMenuItem.Name = "openDebuggerWindowToolStripMenuItem";
            this.openDebuggerWindowToolStripMenuItem.Size = new System.Drawing.Size(414, 44);
            this.openDebuggerWindowToolStripMenuItem.Text = "Open Debugger Window";
            this.openDebuggerWindowToolStripMenuItem.Click += new System.EventHandler(this.openDebuggerWindowToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tetra_hunter_WindowsGUI.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(934, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduz a Frequência (MHz):";
            // 
            // textBox_freq
            // 
            this.textBox_freq.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_freq.Location = new System.Drawing.Point(597, 93);
            this.textBox_freq.Name = "textBox_freq";
            this.textBox_freq.Size = new System.Drawing.Size(203, 44);
            this.textBox_freq.TabIndex = 2;
            // 
            // button_analisar
            // 
            this.button_analisar.Location = new System.Drawing.Point(416, 154);
            this.button_analisar.Name = "button_analisar";
            this.button_analisar.Size = new System.Drawing.Size(163, 75);
            this.button_analisar.TabIndex = 3;
            this.button_analisar.Text = "Analisar";
            this.button_analisar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 722);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_spectrum);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TETRA Hunter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_spectrum.ResumeLayout(false);
            this.groupBox_spectrum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spectrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSpectrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugueseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_spectrum;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugSpectrumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDebuggerWindowToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_freq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_analisar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

