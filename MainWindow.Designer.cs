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
            CipherGUI.CipherManager.RSAManager rsaManager1 = new CipherGUI.CipherManager.RSAManager();
            this.main_panel = new System.Windows.Forms.GroupBox();
            this.combox_encrypt = new System.Windows.Forms.ComboBox();
            this.output_panel = new System.Windows.Forms.GroupBox();
            this.output_text = new System.Windows.Forms.RichTextBox();
            this.input_panel = new System.Windows.Forms.GroupBox();
            this.input_text = new System.Windows.Forms.RichTextBox();
            this.ButtonAction = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.output_panel.SuspendLayout();
            this.input_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.ButtonAction);
            this.main_panel.Controls.Add(this.combox_encrypt);
            this.main_panel.Controls.Add(this.output_panel);
            this.main_panel.Controls.Add(this.input_panel);
            this.main_panel.Location = new System.Drawing.Point(12, 11);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(777, 428);
            this.main_panel.TabIndex = 0;
            this.main_panel.TabStop = false;
            // 
            // combox_encrypt
            // 
            this.combox_encrypt.FormattingEnabled = true;
            this.combox_encrypt.Items.AddRange(new object[] {
            rsaManager1});
            this.combox_encrypt.Location = new System.Drawing.Point(333, 158);
            this.combox_encrypt.Name = "combox_encrypt";
            this.combox_encrypt.Size = new System.Drawing.Size(114, 21);
            this.combox_encrypt.TabIndex = 2;
            this.combox_encrypt.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // output_panel
            // 
            this.output_panel.Controls.Add(this.output_text);
            this.output_panel.Location = new System.Drawing.Point(475, 65);
            this.output_panel.Name = "output_panel";
            this.output_panel.Size = new System.Drawing.Size(301, 362);
            this.output_panel.TabIndex = 1;
            this.output_panel.TabStop = false;
            this.output_panel.Text = "Output";
            // 
            // output_text
            // 
            this.output_text.Location = new System.Drawing.Point(6, 22);
            this.output_text.Name = "output_text";
            this.output_text.Size = new System.Drawing.Size(289, 341);
            this.output_text.TabIndex = 0;
            this.output_text.Text = "";
            this.output_text.TextChanged += new System.EventHandler(this.Output_text_TextChanged);
            // 
            // input_panel
            // 
            this.input_panel.Controls.Add(this.input_text);
            this.input_panel.Location = new System.Drawing.Point(11, 68);
            this.input_panel.Name = "input_panel";
            this.input_panel.Size = new System.Drawing.Size(290, 359);
            this.input_panel.TabIndex = 0;
            this.input_panel.TabStop = false;
            this.input_panel.Text = "Input";
            // 
            // input_text
            // 
            this.input_text.Location = new System.Drawing.Point(6, 19);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(278, 339);
            this.input_text.TabIndex = 0;
            this.input_text.Text = "";
            this.input_text.TextChanged += new System.EventHandler(this.Input_text_TextChanged);
            // 
            // ButtonAction
            // 
            this.ButtonAction.Location = new System.Drawing.Point(333, 238);
            this.ButtonAction.Name = "ButtonAction";
            this.ButtonAction.Size = new System.Drawing.Size(114, 32);
            this.ButtonAction.TabIndex = 3;
            this.ButtonAction.Text = "Encrypt";
            this.ButtonAction.UseVisualStyleBackColor = true;
            this.ButtonAction.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_panel);
            this.Name = "MainWindow";
            this.Text = "Cipher";
            this.main_panel.ResumeLayout(false);
            this.output_panel.ResumeLayout(false);
            this.input_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        #endregion

        private System.Windows.Forms.GroupBox main_panel;
        private System.Windows.Forms.ComboBox combox_encrypt;
        private System.Windows.Forms.GroupBox output_panel;
        private System.Windows.Forms.RichTextBox output_text;
        private System.Windows.Forms.GroupBox input_panel;
        private System.Windows.Forms.RichTextBox input_text;
        private System.Windows.Forms.Button ButtonAction;
    }
}

