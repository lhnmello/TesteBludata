using TesteBludataLib.Models;

namespace TesteBludataForms
{
    partial class VincularForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.fornecedoresListBox = new System.Windows.Forms.ListBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboFornecedoresDisponiveis = new System.Windows.Forms.ComboBox();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(13, 299);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(126, 26);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // fornecedoresListBox
            // 
            this.fornecedoresListBox.DataSource = this.fornecedorBindingSource;
            this.fornecedoresListBox.DisplayMember = "Nome";
            this.fornecedoresListBox.FormattingEnabled = true;
            this.fornecedoresListBox.Location = new System.Drawing.Point(12, 13);
            this.fornecedoresListBox.Name = "fornecedoresListBox";
            this.fornecedoresListBox.Size = new System.Drawing.Size(260, 251);
            this.fornecedoresListBox.TabIndex = 1;
            this.fornecedoresListBox.ValueMember = "Nome";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(TesteBludataLib.Models.Fornecedor);
            // 
            // comboFornecedoresDisponiveis
            // 
            this.comboFornecedoresDisponiveis.DataSource = this.fornecedorBindingSource;
            this.comboFornecedoresDisponiveis.DisplayMember = "Nome";
            this.comboFornecedoresDisponiveis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFornecedoresDisponiveis.FormattingEnabled = true;
            this.comboFornecedoresDisponiveis.Location = new System.Drawing.Point(80, 270);
            this.comboFornecedoresDisponiveis.Name = "comboFornecedoresDisponiveis";
            this.comboFornecedoresDisponiveis.Size = new System.Drawing.Size(191, 21);
            this.comboFornecedoresDisponiveis.TabIndex = 2;
            this.comboFornecedoresDisponiveis.ValueMember = "Nome";
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(145, 299);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(126, 26);
            this.buttonRemover.TabIndex = 4;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.ButtonRemover_Click);
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(TesteBludataLib.Models.Empresa);
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Location = new System.Drawing.Point(9, 273);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(64, 13);
            this.labelFornecedor.TabIndex = 3;
            this.labelFornecedor.Text = "Fornecedor:";
            // 
            // VincularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 337);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.comboFornecedoresDisponiveis);
            this.Controls.Add(this.fornecedoresListBox);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VincularForm";
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.FornecedoresDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ListBox fornecedoresListBox;
        private System.Windows.Forms.ComboBox comboFornecedoresDisponiveis;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.Label labelFornecedor;
    }
}