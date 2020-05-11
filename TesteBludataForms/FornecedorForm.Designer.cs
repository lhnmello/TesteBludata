namespace TesteBludataForms
{
    partial class FornecedorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FornecedorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pessoaJuridicaRadioButton = new System.Windows.Forms.RadioButton();
            this.pessoaFisicaRadioButton = new System.Windows.Forms.RadioButton();
            this.fornecedoresGridView = new System.Windows.Forms.DataGridView();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNomeEmpresa = new System.Windows.Forms.Label();
            this.labelCpfCnpj = new System.Windows.Forms.Label();
            this.CpfCnpjTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.labelTelefones = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.rgTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.telefonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonesUserControl = new TesteBludataForms.TelefonesUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo Pessoa";
            // 
            // pessoaJuridicaRadioButton
            // 
            this.pessoaJuridicaRadioButton.AutoSize = true;
            this.pessoaJuridicaRadioButton.Location = new System.Drawing.Point(72, 181);
            this.pessoaJuridicaRadioButton.Name = "pessoaJuridicaRadioButton";
            this.pessoaJuridicaRadioButton.Size = new System.Drawing.Size(63, 17);
            this.pessoaJuridicaRadioButton.TabIndex = 2;
            this.pessoaJuridicaRadioButton.TabStop = true;
            this.pessoaJuridicaRadioButton.Text = "Jurídica";
            this.pessoaJuridicaRadioButton.UseVisualStyleBackColor = true;
            this.pessoaJuridicaRadioButton.CheckedChanged += new System.EventHandler(this.RadioPessoaJuridica_CheckedChanged);
            // 
            // pessoaFisicaRadioButton
            // 
            this.pessoaFisicaRadioButton.AutoSize = true;
            this.pessoaFisicaRadioButton.Checked = true;
            this.pessoaFisicaRadioButton.Location = new System.Drawing.Point(12, 181);
            this.pessoaFisicaRadioButton.Name = "pessoaFisicaRadioButton";
            this.pessoaFisicaRadioButton.Size = new System.Drawing.Size(54, 17);
            this.pessoaFisicaRadioButton.TabIndex = 1;
            this.pessoaFisicaRadioButton.TabStop = true;
            this.pessoaFisicaRadioButton.Text = "Física";
            this.pessoaFisicaRadioButton.UseVisualStyleBackColor = true;
            this.pessoaFisicaRadioButton.CheckedChanged += new System.EventHandler(this.RadioPessoaFisica_CheckedChanged);
            // 
            // fornecedoresGridView
            // 
            this.fornecedoresGridView.AllowUserToAddRows = false;
            this.fornecedoresGridView.AllowUserToDeleteRows = false;
            this.fornecedoresGridView.AutoGenerateColumns = false;
            this.fornecedoresGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fornecedoresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedoresGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFornecedorDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataHoraCadastroDataGridViewTextBoxColumn});
            this.fornecedoresGridView.DataSource = this.fornecedorBindingSource;
            this.fornecedoresGridView.Location = new System.Drawing.Point(12, 2);
            this.fornecedoresGridView.Name = "fornecedoresGridView";
            this.fornecedoresGridView.ReadOnly = true;
            this.fornecedoresGridView.RowHeadersVisible = false;
            this.fornecedoresGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fornecedoresGridView.Size = new System.Drawing.Size(775, 150);
            this.fornecedoresGridView.TabIndex = 4;
            this.fornecedoresGridView.TabStop = false;
            this.fornecedoresGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FornecedoresGridView_ColumnHeaderMouseDoubleClick);
            this.fornecedoresGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.FornecedoresGridView_RowStateChanged);
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "IdFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "IdFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            this.idFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFornecedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CpfCnpj";
            this.dataGridViewTextBoxColumn1.HeaderText = "CPF / CNPJ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataHoraCadastroDataGridViewTextBoxColumn
            // 
            this.dataHoraCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataHoraCadastro";
            this.dataHoraCadastroDataGridViewTextBoxColumn.HeaderText = "Data/Hora Cadastro";
            this.dataHoraCadastroDataGridViewTextBoxColumn.Name = "dataHoraCadastroDataGridViewTextBoxColumn";
            this.dataHoraCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(TesteBludataLib.Models.Fornecedor);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 228);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome:";
            // 
            // labelNomeEmpresa
            // 
            this.labelNomeEmpresa.AutoSize = true;
            this.labelNomeEmpresa.Location = new System.Drawing.Point(391, 183);
            this.labelNomeEmpresa.Name = "labelNomeEmpresa";
            this.labelNomeEmpresa.Size = new System.Drawing.Size(0, 13);
            this.labelNomeEmpresa.TabIndex = 8;
            // 
            // labelCpfCnpj
            // 
            this.labelCpfCnpj.AutoSize = true;
            this.labelCpfCnpj.Location = new System.Drawing.Point(12, 256);
            this.labelCpfCnpj.Name = "labelCpfCnpj";
            this.labelCpfCnpj.Size = new System.Drawing.Size(30, 13);
            this.labelCpfCnpj.TabIndex = 8;
            this.labelCpfCnpj.Text = "CPF:";
            // 
            // CpfCnpjTextBox
            // 
            this.CpfCnpjTextBox.Location = new System.Drawing.Point(75, 253);
            this.CpfCnpjTextBox.Mask = "###.###.###-##";
            this.CpfCnpjTextBox.Name = "CpfCnpjTextBox";
            this.CpfCnpjTextBox.Size = new System.Drawing.Size(115, 20);
            this.CpfCnpjTextBox.TabIndex = 4;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(75, 225);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(145, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // labelTelefones
            // 
            this.labelTelefones.AutoSize = true;
            this.labelTelefones.Location = new System.Drawing.Point(9, 286);
            this.labelTelefones.Name = "labelTelefones";
            this.labelTelefones.Size = new System.Drawing.Size(63, 13);
            this.labelTelefones.TabIndex = 8;
            this.labelTelefones.Text = "Telefone(s):";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Location = new System.Drawing.Point(322, 228);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(66, 13);
            this.labelNascimento.TabIndex = 8;
            this.labelNascimento.Text = "Nascimento:";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Location = new System.Drawing.Point(322, 256);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(26, 13);
            this.labelRG.TabIndex = 8;
            this.labelRG.Text = "RG:";
            // 
            // rgTextBox
            // 
            this.rgTextBox.Location = new System.Drawing.Point(394, 253);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(100, 20);
            this.rgTextBox.TabIndex = 7;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(677, 409);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(111, 23);
            this.buttonLimpar.TabIndex = 11;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(560, 409);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(111, 23);
            this.buttonRemover.TabIndex = 10;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.ButtonRemover_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(443, 409);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(111, 23);
            this.buttonAlterar.TabIndex = 9;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.ButtonAlterar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(326, 409);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(111, 23);
            this.buttonAdicionar.TabIndex = 8;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // nascimentoDateTimePicker
            // 
            this.nascimentoDateTimePicker.Location = new System.Drawing.Point(394, 225);
            this.nascimentoDateTimePicker.Name = "nascimentoDateTimePicker";
            this.nascimentoDateTimePicker.Size = new System.Drawing.Size(211, 20);
            this.nascimentoDateTimePicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empresa:";
            // 
            // telefonesBindingSource
            // 
            this.telefonesBindingSource.DataMember = "Telefones";
            this.telefonesBindingSource.DataSource = this.fornecedorBindingSource;
            // 
            // telefonesUserControl
            // 
            this.telefonesUserControl.AutoScroll = true;
            this.telefonesUserControl.Location = new System.Drawing.Point(72, 273);
            this.telefonesUserControl.Name = "telefonesUserControl";
            this.telefonesUserControl.Size = new System.Drawing.Size(238, 156);
            this.telefonesUserControl.TabIndex = 5;
            this.telefonesUserControl.Telefones = ((System.Collections.Generic.List<string>)(resources.GetObject("telefonesUserControl.Telefones")));
            // 
            // FornecedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.telefonesUserControl);
            this.Controls.Add(this.nascimentoDateTimePicker);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.rgTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.CpfCnpjTextBox);
            this.Controls.Add(this.labelRG);
            this.Controls.Add(this.labelTelefones);
            this.Controls.Add(this.labelCpfCnpj);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNomeEmpresa);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pessoaJuridicaRadioButton);
            this.Controls.Add(this.pessoaFisicaRadioButton);
            this.Controls.Add(this.fornecedoresGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FornecedorForm";
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.FornecedorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton pessoaJuridicaRadioButton;
        private System.Windows.Forms.RadioButton pessoaFisicaRadioButton;
        private System.Windows.Forms.DataGridView fornecedoresGridView;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNomeEmpresa;
        private System.Windows.Forms.Label labelCpfCnpj;
        private System.Windows.Forms.MaskedTextBox CpfCnpjTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label labelTelefones;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.MaskedTextBox rgTextBox;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.DateTimePicker nascimentoDateTimePicker;
        private TelefonesUserControl telefonesUserControl;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource telefonesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraCadastroDataGridViewTextBoxColumn;
    }
}