using System;
using System.Windows.Forms;

namespace Instalador_Tradução_Bannerlord.Forms
{
    public partial class FormApresentacao : Form
    {
        public FormApresentacao()
        {
            InitializeComponent();
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FormDiretorio().ShowDialog();
        }

        private void buttonProximo_MouseLeave(object sender, EventArgs e)
        {
            this.buttonProximo.BackgroundImage = Properties.Resources.botao_proximo;
        }

        private void buttonProximo_MouseHover(object sender, EventArgs e)
        {
            this.buttonProximo.BackgroundImage = Properties.Resources.botao_proximo_hover;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}