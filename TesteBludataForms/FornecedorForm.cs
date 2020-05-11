using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TesteBludataLib.Models;
using TesteBludataLib.Regras;

namespace TesteBludataForms
{
    public partial class FornecedorForm : Form
    {
        private List<Fornecedor> listaFornecedores;

        private readonly string CNPJ_MASK = "##.###.###/####-##";
        private readonly string CPF_MASK = "###.###.###-##";
        private readonly string CNPJ_LABEL = "CNPJ:";
        private readonly string CPF_LABEL = "CPF:";

        private readonly FornecedorBLL fornecedorBLL;

        private int idFornecedorSelecionado;
        public FornecedorForm()
        {
            InitializeComponent();

            fornecedorBLL = new FornecedorBLL();
        }
        private void FornecedorForm_Load(object sender, EventArgs e)
        {
            AtualizaDados();
        }

        private void RadioPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            TipoPessoaChanged(TipoPessoa.Fisica);
        }

        private void RadioPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            TipoPessoaChanged(TipoPessoa.Juridica);
        }

        private void TipoPessoaChanged(TipoPessoa tipoPessoa)
        {
            bool isPessoaFisica = tipoPessoa == TipoPessoa.Fisica;

            labelCpfCnpj.Text = isPessoaFisica ? CPF_LABEL : CNPJ_LABEL;
            CpfCnpjTextBox.Mask = isPessoaFisica ? CPF_MASK : CNPJ_MASK;

            labelRG.Visible = isPessoaFisica;
            rgTextBox.Visible = isPessoaFisica;
            labelNascimento.Visible = isPessoaFisica;
            nascimentoDateTimePicker.Visible = isPessoaFisica;
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            var fornecedor = GetDadosTela();

            try
            {
                fornecedorBLL.Gravar(fornecedor);

                AtualizaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonAlterar_Click(object sender, EventArgs e)
        {
            var fornecedor = GetDadosTela();

            fornecedor.IdFornecedor = idFornecedorSelecionado;

            try
            {
                fornecedorBLL.Alterar(fornecedor);

                AtualizaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonRemover_Click(object sender, EventArgs e)
        {
            var fornecedor = GetDadosTela();

            fornecedor.IdFornecedor = idFornecedorSelecionado;

            try
            {
                fornecedorBLL.Remover(fornecedor);

                AtualizaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostraRegistros(Fornecedor fornecedor)
        {
            telefonesUserControl.Reset();

            if (fornecedor is FornecedorPF fornecedorPF)
            {
                pessoaFisicaRadioButton.Checked = true;

                rgTextBox.Text = fornecedorPF.Rg;
                nascimentoDateTimePicker.Value = fornecedorPF.DataNascimento;
            }
            else
            {
                pessoaJuridicaRadioButton.Checked = true;
            }

            nomeTextBox.Text = fornecedor.Nome;
            CpfCnpjTextBox.Text = fornecedor.CpfCnpj;

            labelNomeEmpresa.Text = fornecedor.Empresa?.NomeFantasia;

            idFornecedorSelecionado = fornecedor.IdFornecedor;

            telefonesUserControl.SetTelefones(fornecedor.Telefones);

            UpdateBotoes();
        }

        private void LimpaCampos()
        {
            nomeTextBox.Text = "";
            CpfCnpjTextBox.Text = "";
            rgTextBox.Text = "";
            nascimentoDateTimePicker.Value = DateTime.Now;
            idFornecedorSelecionado = 0;
            labelNomeEmpresa.Text = "";

            telefonesUserControl.Reset();

            fornecedoresGridView.ClearSelection();

            UpdateBotoes();
        }

        private void UpdateBotoes()
        {
            buttonAlterar.Enabled = idFornecedorSelecionado != 0;
            buttonRemover.Enabled = idFornecedorSelecionado != 0;
        }
        private Fornecedor GetDadosTela()
        {
            if (pessoaFisicaRadioButton.Checked)
            {
                return new FornecedorPF()
                {
                    Nome = nomeTextBox.Text,
                    CpfCnpj = CpfCnpjTextBox.Text,
                    DataNascimento = nascimentoDateTimePicker.Value,
                    Rg = rgTextBox.Text,
                    Telefones = telefonesUserControl.GetTelefones()
                };
            }

            return new FornecedorPJ()
            {
                Nome = nomeTextBox.Text,
                CpfCnpj = CpfCnpjTextBox.Text,
                Telefones = telefonesUserControl.GetTelefones()
            };
        }
        private void AtualizaDados()
        {
            listaFornecedores = fornecedorBLL.Ler();

            fornecedoresGridView.DataSource = null;
            fornecedoresGridView.DataSource = listaFornecedores;

            LimpaCampos();
        }
        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void FornecedoresGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if (fornecedoresGridView.SelectedRows == null || fornecedoresGridView.SelectedRows.Count == 0)
                return;

            DataGridViewRow linhaSelecionada = fornecedoresGridView.SelectedRows[0];

            Fornecedor fornecedor = linhaSelecionada.DataBoundItem as Fornecedor;

            MostraRegistros(fornecedor);
        }

        private void FornecedoresGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string propName = fornecedoresGridView.Columns[e.ColumnIndex].DataPropertyName;

            if (propName == "Nome")
                listaFornecedores.Sort(Fornecedor.OrdenaPorNome);
            else if (propName == "CpfCnpj")
                listaFornecedores.Sort(Fornecedor.OrdenaPorCpfCnpj);
            else if (propName == "DataHoraCadastro")
                listaFornecedores.Sort(Fornecedor.OrdenaPorDataCadastro);

            fornecedoresGridView.DataSource = null;
            fornecedoresGridView.DataSource = listaFornecedores;
        }
    }
}
