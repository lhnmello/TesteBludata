using System;
using System.Windows.Forms;

namespace TesteBludataForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EmpresaMenuItem_Click(object sender, EventArgs e)
        {
            new EmpresaForm().Show();                
        }

        private void FornecedorMenuItem_Click(object sender, EventArgs e)
        {
            new FornecedorForm().Show();
        }

        private void VincularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VincularForm().Show();
        }
    }
}
