using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TesteBludataLib.Models;
using TesteBludataLib.Regras;

namespace TesteBludataForms
{
    public partial class VincularForm : Form
    {
        private readonly List<Fornecedor> fornecedores;
        private readonly List<Fornecedor> fornecedoresDisponiveis;

        private readonly EmpresaBLL empresaBLL;
        private readonly FornecedorBLL fornecedorBLL;

        private readonly Empresa empresa;
        public VincularForm()
        {
            fornecedorBLL = new FornecedorBLL();
            empresaBLL = new EmpresaBLL();

            InitializeComponent();

            empresa = empresaBLL.Ler();

            if (empresa == null)
            {
                Enabled = false;
            }
            else
            {
                if (empresa.Fornecedores != null)
                {
                    fornecedores = empresa.Fornecedores;

                    fornecedoresDisponiveis = fornecedorBLL.Ler().Except(fornecedores).ToList();
                }
                else
                    fornecedoresDisponiveis = fornecedorBLL.Ler();
            }

            PreencheListBox();
            PreencheComboFornecedoresDisponiveis();
        }

        private void PreencheListBox()
        {
            fornecedoresListBox.DataSource = null;
            fornecedoresListBox.DataSource = fornecedores;
        }

        private void PreencheComboFornecedoresDisponiveis()
        {
            comboFornecedoresDisponiveis.DataSource = null;
            comboFornecedoresDisponiveis.DataSource = fornecedoresDisponiveis;
        }

        private void FornecedoresDialog_Load(object sender, EventArgs e)
        {
            PreencheListBox();
            PreencheComboFornecedoresDisponiveis();
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            if (!(comboFornecedoresDisponiveis.SelectedItem is Fornecedor fornecedor))
                return;

            try
            {
                empresa.AdicionaFornecedor(fornecedor);
                fornecedor.SetEmpresa(empresa);

                empresaBLL.Gravar(empresa);
                fornecedorBLL.Alterar(fornecedor);

                fornecedoresDisponiveis.Remove(fornecedor);

                PreencheListBox();
                PreencheComboFornecedoresDisponiveis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonRemover_Click(object sender, EventArgs e)
        {
            if (!(fornecedoresListBox.SelectedItem is Fornecedor fornecedor))
                return;

            try
            {
                empresa.RemoveFornecedor(fornecedor);
                fornecedor.SetEmpresa(null);

                fornecedorBLL.Alterar(fornecedor);
                empresaBLL.Gravar(empresa);

                fornecedoresDisponiveis.Add(fornecedor);

                PreencheListBox();
                PreencheComboFornecedoresDisponiveis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
