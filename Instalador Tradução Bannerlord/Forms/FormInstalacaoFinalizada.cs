using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Instalador_Tradução_Bannerlord.Forms
{
    public partial class FormInstalacaoFinalizada : Form
    {
        public FormInstalacaoFinalizada()
        {
            InitializeComponent();
        }

        private void panelDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/8tygPS2");
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}