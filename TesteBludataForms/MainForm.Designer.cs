namespace TesteBludataForms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.empresaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vincularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaMenuItem,
            this.fornecedorMenuItem,
            this.vincularToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // empresaMenuItem
            // 
            this.empresaMenuItem.Name = "empresaMenuItem";
            this.empresaMenuItem.Size = new System.Drawing.Size(64, 20);
            this.empresaMenuItem.Text = "Empresa";
            this.empresaMenuItem.Click += new System.EventHandler(this.EmpresaMenuItem_Click);
            // 
            // fornecedorMenuItem
            // 
            this.fornecedorMenuItem.Name = "fornecedorMenuItem";
            this.fornecedorMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fornecedorMenuItem.Text = "Fornecedor";
            this.fornecedorMenuItem.Click += new System.EventHandler(this.FornecedorMenuItem_Click);
            // 
            // vincularToolStripMenuItem
            // 
            this.vincularToolStripMenuItem.Name = "vincularToolStripMenuItem";
            this.vincularToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.vincularToolStripMenuItem.Text = "Vincular";
            this.vincularToolStripMenuItem.Click += new System.EventHandler(this.VincularToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem empresaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vincularToolStripMenuItem;
    }
}

