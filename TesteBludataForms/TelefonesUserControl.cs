using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TesteBludataForms
{
    public partial class TelefonesUserControl : UserControl
    {
        private readonly List<MaskedTextBox> textTelefones;
        public List<String> Telefones { get; set; }

        private readonly int TEXT_WIDTH;

        private readonly int DISTANCE_Y = 5;

        private int nextTextPosX;
        private int nextTextPosY;

        private readonly int buttonPosX;
        private readonly int buttonPosY;

        private readonly string MASK_TELEFONE = "(##)#####-####";

        public TelefonesUserControl()
        {
            InitializeComponent();

            textTelefones = new List<MaskedTextBox>();

            Telefones = new List<string>();

            TEXT_WIDTH = telefoneTextBox.Width;

            telefoneTextBox.Visible = false;

            buttonPosX = buttonAdicionarMais.Location.X;
            buttonPosY = buttonAdicionarMais.Location.Y;

            AutoScroll = true;

            Reset();
        }

        private void ButtonAdicionarMais_Click(object sender, EventArgs e)
        {
            AdicionaTelefone(string.Empty);
        }

        private void AdicionaTelefone(string text)
        {
            MaskedTextBox textBox = new MaskedTextBox
            {
                Width = TEXT_WIDTH,
                Location = new Point(nextTextPosX, nextTextPosY),
                Mask = MASK_TELEFONE,
                Text = text,
                TabIndex = textTelefones.Count + 1
            };

            buttonAdicionarMais.TabIndex = textBox.TabIndex + 1;

            this.Controls.Add(textBox);

            nextTextPosY += DISTANCE_Y + textBox.Height;

            textTelefones.Add(textBox);

            buttonAdicionarMais.Location = new Point(buttonPosX, buttonPosY);
        }

        public void SetTelefones(List<string> telefones)
        {
            if (telefones == null || telefones.Count == 0)
                return;

            Clear();

            Telefones = telefones;

            foreach (var telefone in telefones)
            {
                AdicionaTelefone(telefone);
            }
        }

        public void Clear()
        {
            nextTextPosX = telefoneTextBox.Location.X;
            nextTextPosY = telefoneTextBox.Location.Y;

            Controls.Clear();

            Controls.Add(buttonAdicionarMais);

            textTelefones.Clear();   
        }
        public void Reset()
        {
            Clear();
            AdicionaTelefone(string.Empty);
        }
        public List<string> GetTelefones()
        {
            var retorno = new List<string>();

            foreach (var text in textTelefones)
            {
                if (!string.IsNullOrEmpty(text.Text) && text.Text.Trim() != "(  )     -")
                    retorno.Add(text.Text);
            }

            return retorno;
        }
    }
}
