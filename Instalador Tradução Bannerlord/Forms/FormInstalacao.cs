using Instalador_Tradução_Bannerlord.FileManagement;
using System;
using System.Windows.Forms;

namespace Instalador_Tradução_Bannerlord.Forms
{
    public partial class FormInstalacao : Form
    {
        private readonly string _baseDiretory;
        private readonly bool _deleteConfigs;

        public FormInstalacao(string baseDiretory, bool deleteConfigs)
        {
            InitializeComponent();
            _baseDiretory = baseDiretory;
            _deleteConfigs = deleteConfigs;
        }

        private void FormInstalação_Load(object sender, EventArgs e)
        {
            try
            {
                FileManager.DeleteFiles(_baseDiretory);
                FileManager.CopyFiles("files", _baseDiretory);

                if (_deleteConfigs)
                    FileManager.DeleteConfigFiles();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.Abort;
            }
            this.Close();
        }
    }
}