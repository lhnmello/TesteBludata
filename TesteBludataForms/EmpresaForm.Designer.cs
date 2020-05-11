using TesteBludataLib.Models;

namespace TesteBludataForms
{
    partial class EmpresaForm
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
            this.labelUf = new System.Windows.Forms.Label();
            this.nomeFantasiaTextBox = new System.Windows.Forms.TextBox();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.labelNomeFantasia = new System.Windows.Forms.Label();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.cnpjTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelFornecedores = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelNomesFornecedores = new System.Windows.Forms.Label();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.Location = new System.Drawing.Point(21, 41);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(24, 13);
            this.labelUf.TabIndex = 1;
            this.labelUf.Text = "UF:";
            // 
            // nomeFantasiaTextBox
            // 
            this.nomeFantasiaTextBox.Location = new System.Drawing.Point(167, 12);
            this.nomeFantasiaTextBox.MaxLength = 50;
            this.nomeFantasiaTextBox.Name = "nomeFantasiaTextBox";
            this.nomeFantasiaTextBox.Size = new System.Drawing.Size(162, 20);
            this.nomeFantasiaTextBox.TabIndex = 1;
            // 
            // comboUF
            // 
            this.comboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(167, 38);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(79, 21);
            this.comboUF.TabIndex = 2;
            // 
            // labelNomeFantasia
            // 
            this.labelNomeFantasia.AutoSize = true;
            this.labelNomeFantasia.Location = new System.Drawing.Point(21, 15);
            this.labelNomeFantasia.Name = "labelNomeFantasia";
            this.labelNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.labelNomeFantasia.TabIndex = 4;
            this.labelNomeFantasia.Text = "Nome Fantasia:";
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(21, 68);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(37, 13);
            this.labelCnpj.TabIndex = 4;
            this.labelCnpj.Text = "CNPJ:";
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.Location = new System.Drawing.Point(167, 65);
            this.cnpjTextBox.Mask = "##.###.###/####-##";
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(125, 20);
            this.cnpjTextBox.TabIndex = 3;
            // 
            // labelFornecedores
            // 
            this.labelFornecedores.AutoSize = true;
            this.labelFornecedores.Location = new System.Drawing.Point(21, 96);
            this.labelFornecedores.Name = "labelFornecedores";
            this.labelFornecedores.Size = new System.Drawing.Size(81, 13);
            this.labelFornecedores.TabIndex = 4;
            this.labelFornecedores.Text = "Fornecedor(es):";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(439, 128);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(111, 23);
            this.buttonGravar.TabIndex = 5;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.ButtonGravar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(322, 128);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(111, 23);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // labelNomesFornecedores
            // 
            this.labelNomesFornecedores.AutoSize = true;
            this.labelNomesFornecedores.Location = new System.Drawing.Point(164, 96);
            this.labelNomesFornecedores.Name = "labelNomesFornecedores";
            this.labelNomesFornecedores.Size = new System.Drawing.Size(0, 13);
            this.labelNomesFornecedores.TabIndex = 4;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataSource = typeof(TesteBludataLib.Models.Empresa);
            // 
            // EmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 164);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(this.labelNomesFornecedores);
            this.Controls.Add(this.labelFornecedores);
            this.Controls.Add(this.labelCnpj);
            this.Controls.Add(this.labelNomeFantasia);
            this.Controls.Add(this.comboUF);
            this.Controls.Add(this.nomeFantasiaTextBox);
            this.Controls.Add(this.labelUf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmpresaForm";
            this.Text = "Dados da Empresa";
            this.Load += new System.EventHandler(this.EmpresaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUf;
        private System.Windows.Forms.TextBox nomeFantasiaTextBox;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.Label labelNomeFantasia;
        private System.Windows.Forms.Label labelCnpj;
        private System.Windows.Forms.MaskedTextBox cnpjTextBox;
        private System.Windows.Forms.Label labelFornecedores;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private System.Windows.Forms.Label labelNomesFornecedores;
    }
}