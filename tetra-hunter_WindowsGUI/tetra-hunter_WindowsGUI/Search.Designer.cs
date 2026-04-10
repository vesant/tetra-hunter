namespace tetra_hunter_WindowsGUI {
    partial class autoSearch_forms {
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
            this.button_search = new System.Windows.Forms.Button();
            this.button_loadConf = new System.Windows.Forms.Button();
            this.listBox_logs = new System.Windows.Forms.ListBox();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(12, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(163, 101);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Pesquisar\r\n(Default)\r\n";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_loadConf
            // 
            this.button_loadConf.Location = new System.Drawing.Point(253, 12);
            this.button_loadConf.Name = "button_loadConf";
            this.button_loadConf.Size = new System.Drawing.Size(163, 101);
            this.button_loadConf.TabIndex = 1;
            this.button_loadConf.Text = "Load Config.";
            this.button_loadConf.UseVisualStyleBackColor = true;
            this.button_loadConf.Click += new System.EventHandler(this.button_loadConf_Click);
            // 
            // listBox_logs
            // 
            this.listBox_logs.FormattingEnabled = true;
            this.listBox_logs.ItemHeight = 25;
            this.listBox_logs.Location = new System.Drawing.Point(12, 119);
            this.listBox_logs.Name = "listBox_logs";
            this.listBox_logs.Size = new System.Drawing.Size(644, 404);
            this.listBox_logs.TabIndex = 2;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(493, 12);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(163, 101);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // autoSearch_forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 535);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.listBox_logs);
            this.Controls.Add(this.button_loadConf);
            this.Controls.Add(this.button_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "autoSearch_forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Search";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_loadConf;
        private System.Windows.Forms.ListBox listBox_logs;
        private System.Windows.Forms.Button button_save;
    }
}