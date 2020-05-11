namespace TesteBludataForms
{
    partial class TelefonesUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdicionarMais = new System.Windows.Forms.Button();
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonAdicionarMais
            // 
            this.buttonAdicionarMais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdicionarMais.Location = new System.Drawing.Point(126, 3);
            this.buttonAdicionarMais.Name = "buttonAdicionarMais";
            this.buttonAdicionarMais.Size = new System.Drawing.Size(86, 31);
            this.buttonAdicionarMais.TabIndex = 1;
            this.buttonAdicionarMais.Text = "Adicionar mais";
            this.buttonAdicionarMais.UseVisualStyleBackColor = true;
            this.buttonAdicionarMais.Click += new System.EventHandler(this.ButtonAdicionarMais_Click);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(4, 9);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(116, 20);
            this.telefoneTextBox.TabIndex = 2;
            // 
            // TelefonesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.buttonAdicionarMais);
            this.Name = "TelefonesUserControl";
            this.Size = new System.Drawing.Size(218, 162);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdicionarMais;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
    }
}
