namespace Scanner_Log
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ports_cb = new System.Windows.Forms.ComboBox();
            this.textLog = new System.Windows.Forms.RichTextBox();
            this.portConnected = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ports_cb
            // 
            this.ports_cb.FormattingEnabled = true;
            this.ports_cb.Location = new System.Drawing.Point(467, 107);
            this.ports_cb.Name = "ports_cb";
            this.ports_cb.Size = new System.Drawing.Size(152, 21);
            this.ports_cb.TabIndex = 0;
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(124, 107);
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(319, 105);
            this.textLog.TabIndex = 1;
            this.textLog.Text = "";
            // 
            // portConnected
            // 
            this.portConnected.Location = new System.Drawing.Point(467, 192);
            this.portConnected.Name = "portConnected";
            this.portConnected.Size = new System.Drawing.Size(152, 20);
            this.portConnected.TabIndex = 2;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(467, 163);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(71, 23);
            this.connectBtn.TabIndex = 3;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(544, 163);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(75, 23);
            this.disconnectBtn.TabIndex = 4;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(467, 134);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(152, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh Ports";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.portConnected);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.ports_cb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ports_cb;
        private System.Windows.Forms.RichTextBox textLog;
        private System.Windows.Forms.TextBox portConnected;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}

