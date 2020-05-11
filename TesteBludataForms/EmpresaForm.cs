using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TesteBludataLib.Models;
using TesteBludataLib.Regras;

namespace TesteBludataForms
{
    public partial class EmpresaForm : Form
    {
        private readonly EmpresaBLL empresaBLL;

        private List<Fornecedor> fornecedoresEmpresaSelecionada;
        public EmpresaForm()
        {
            InitializeComponent();

            empresaBLL = new EmpresaBLL();

            comboUF.DataSource = Enum.GetValues(typeof(Estado));

            LimpaCampos();
        }
        private void ButtonGravar_Click(object sender, EventArgs e)
        {
            var empresa = GetDadosTela();

            try
            {
                empresaBLL.Gravar(empresa);

                MessageBox.Show("Dados gravados com sucesso.");

                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EmpresaForm_Load(object sender, EventArgs e)
        {
            MostraRegistros(empresaBLL.Ler());
        }

        private void MostraRegistros(Empresa empresa)
        {
            if (empresa == null)
                return;

            nomeFantasiaTextBox.Text = empresa.NomeFantasia;
            comboUF.SelectedItem = empresa.Uf;
            cnpjTextBox.Text = empresa.Cnpj;

            fornecedoresEmpresaSelecionada = empresa.Fornecedores;

            UpdateLabelFornecedores();
        }

        private void UpdateLabelFornecedores()
        {
            if (fornecedoresEmpresaSelecionada != null)
                labelNomesFornecedores.Text = string.Join(", ", fornecedoresEmpresaSelecionada);
        }

        private void LimpaCampos()
        {
            nomeFantasiaTextBox.Text = "";
            cnpjTextBox.Text = "";
            comboUF.SelectedItem = Estado.Nenhum;
        }

        private Empresa GetDadosTela()
        {
            return new Empresa()
            {
                NomeFantasia = nomeFantasiaTextBox.Text,
                Cnpj = cnpjTextBox.Text,
                Uf = (Estado)comboUF.SelectedItem,
                Fornecedores = fornecedoresEmpresaSelecionada ?? new List<Fornecedor>()
            };
        }
        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
