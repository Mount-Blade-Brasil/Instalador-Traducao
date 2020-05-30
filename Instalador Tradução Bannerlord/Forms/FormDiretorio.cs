using System;
using System.Windows.Forms;

namespace Instalador_Tradução_Bannerlord.Forms
{
    public partial class FormDiretorio : Form
    {
        public FormDiretorio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void buttonProximo_MouseHover(object sender, EventArgs e)
        {
            this.buttonProximo.BackgroundImage = Properties.Resources.botao_instalar_hover;
        }

        private void buttonProximo_MouseLeave(object sender, EventArgs e)
        {
            this.buttonProximo.BackgroundImage = Properties.Resources.botao_instalar;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            textBoxDirectory.Text = FolderDialog();
        }

        private string FolderDialog()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
            }
            return "";
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            var form = new FormInstalacao(textBoxDirectory.Text, checkBoxLimparConfig.Checked);

            if (form.ShowDialog() == DialogResult.Abort)
                MessageBox.Show("Ocorreu um erro ao tentar instalar a tradução. Verifique se o diretório do jogo informado é o correto. Deve ser o diretório raiz.", "Erro na instalação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Visible = false;
                new FormInstalacaoFinalizada().ShowDialog();
            }
        }
    }
}