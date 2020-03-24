namespace CipherGUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            CipherGUI.CipherManager.RSAManager rsaManager2 = new CipherGUI.CipherManager.RSAManager();
            this.input_text = new System.Windows.Forms.RichTextBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.output_text = new System.Windows.Forms.RichTextBox();
            this.combox_encrypt = new System.Windows.Forms.ComboBox();
            this.ButtonAction = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.headPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(0, 3);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(213, 205);
            this.input_text.TabIndex = 0;
            this.input_text.Text = "";
            this.input_text.TextChanged += new System.EventHandler(this.Input_text_TextChanged);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(173, 450);
            this.sidePanel.TabIndex = 1;
            // 
            // output_text
            // 
            this.output_text.Location = new System.Drawing.Point(0, 3);
            this.output_text.Name = "output_text";
            this.output_text.Size = new System.Drawing.Size(214, 202);
            this.output_text.TabIndex = 0;
            this.output_text.Text = "";
            // 
            // combox_encrypt
            // 
            this.combox_encrypt.FormattingEnabled = true;
            this.combox_encrypt.Items.AddRange(new object[] {
            rsaManager2});
            this.combox_encrypt.Location = new System.Drawing.Point(265, 203);
            this.combox_encrypt.Name = "combox_encrypt";
            this.combox_encrypt.Size = new System.Drawing.Size(114, 21);
            this.combox_encrypt.TabIndex = 2;
            this.combox_encrypt.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ButtonAction
            // 
            this.ButtonAction.Location = new System.Drawing.Point(265, 304);
            this.ButtonAction.Name = "ButtonAction";
            this.ButtonAction.Size = new System.Drawing.Size(114, 32);
            this.ButtonAction.TabIndex = 3;
            this.ButtonAction.Text = "Encrypt";
            this.ButtonAction.UseVisualStyleBackColor = true;
            this.ButtonAction.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.mainPanel.Controls.Add(this.outputPanel);
            this.mainPanel.Controls.Add(this.inputPanel);
            this.mainPanel.Controls.Add(this.combox_encrypt);
            this.mainPanel.Controls.Add(this.ButtonAction);
            this.mainPanel.Location = new System.Drawing.Point(172, 53);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(630, 397);
            this.mainPanel.TabIndex = 2;
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.output_text);
            this.outputPanel.Location = new System.Drawing.Point(399, 153);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(217, 208);
            this.outputPanel.TabIndex = 5;
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.input_text);
            this.inputPanel.Location = new System.Drawing.Point(14, 150);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(216, 208);
            this.inputPanel.TabIndex = 4;
            // 
            // headPanel
            // 
            this.headPanel.Location = new System.Drawing.Point(172, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(630, 53);
            this.headPanel.TabIndex = 3;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(172, 52);
            this.logoPanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Cipher";
            this.sidePanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.outputPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox input_text;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.RichTextBox output_text;
        private System.Windows.Forms.ComboBox combox_encrypt;
        private System.Windows.Forms.Button ButtonAction;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel headPanel;
    }
}

