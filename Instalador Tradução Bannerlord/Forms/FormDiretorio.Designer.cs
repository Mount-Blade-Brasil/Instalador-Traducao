using System.Windows.Forms;

namespace Instalador_Tradução_Bannerlord.Forms
{
    partial class FormDiretorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiretorio));
            this.buttonProximo = new System.Windows.Forms.Button();
            this.panelLogoBannerlord = new System.Windows.Forms.Panel();
            this.labelTraducao = new System.Windows.Forms.Label();
            this.labelTextoSelecioneDiretorio = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelDiretorio = new System.Windows.Forms.Label();
            this.checkBoxLimparConfig = new System.Windows.Forms.CheckBox();
            this.labelConfig = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonProximo
            // 
            this.buttonProximo.BackColor = System.Drawing.Color.Transparent;
            this.buttonProximo.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.botao_instalar;
            this.buttonProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProximo.ForeColor = System.Drawing.Color.Transparent;
            this.buttonProximo.Location = new System.Drawing.Point(12, 457);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(345, 54);
            this.buttonProximo.TabIndex = 0;
            this.buttonProximo.UseVisualStyleBackColor = false;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            this.buttonProximo.MouseLeave += new System.EventHandler(this.buttonProximo_MouseLeave);
            this.buttonProximo.MouseHover += new System.EventHandler(this.buttonProximo_MouseHover);
            // 
            // panelLogoBannerlord
            // 
            this.panelLogoBannerlord.BackColor = System.Drawing.Color.Transparent;
            this.panelLogoBannerlord.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.Logo_bannerlord;
            this.panelLogoBannerlord.Location = new System.Drawing.Point(12, 12);
            this.panelLogoBannerlord.Name = "panelLogoBannerlord";
            this.panelLogoBannerlord.Size = new System.Drawing.Size(202, 54);
            this.panelLogoBannerlord.TabIndex = 2;
            // 
            // labelTraducao
            // 
            this.labelTraducao.BackColor = System.Drawing.Color.Transparent;
            this.labelTraducao.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTraducao.ForeColor = System.Drawing.Color.White;
            this.labelTraducao.Location = new System.Drawing.Point(562, 61);
            this.labelTraducao.Name = "labelTraducao";
            this.labelTraducao.Size = new System.Drawing.Size(174, 23);
            this.labelTraducao.TabIndex = 3;
            this.labelTraducao.Text = "Tradução PT-BR";
            // 
            // labelTextoSelecioneDiretorio
            // 
            this.labelTextoSelecioneDiretorio.BackColor = System.Drawing.Color.Transparent;
            this.labelTextoSelecioneDiretorio.ForeColor = System.Drawing.Color.White;
            this.labelTextoSelecioneDiretorio.Location = new System.Drawing.Point(21, 142);
            this.labelTextoSelecioneDiretorio.Name = "labelTextoSelecioneDiretorio";
            this.labelTextoSelecioneDiretorio.Size = new System.Drawing.Size(438, 17);
            this.labelTextoSelecioneDiretorio.TabIndex = 1;
            this.labelTextoSelecioneDiretorio.Text = "Selecione o diretório do jogo:";
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(1000, 0);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(30, 30);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "X";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(24, 162);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(366, 20);
            this.textBoxDirectory.TabIndex = 6;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(396, 159);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 5;
            this.buttonBrowse.Text = "Selecionar";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelDiretorio
            // 
            this.labelDiretorio.BackColor = System.Drawing.Color.Transparent;
            this.labelDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiretorio.ForeColor = System.Drawing.Color.White;
            this.labelDiretorio.Location = new System.Drawing.Point(21, 185);
            this.labelDiretorio.Name = "labelDiretorio";
            this.labelDiretorio.Size = new System.Drawing.Size(469, 20);
            this.labelDiretorio.TabIndex = 7;
            this.labelDiretorio.Text = "Geralmente em C:\\Program Files (x86)\\Steam\\steamapps\\common\\Mount & Blade II Bann" +
    "erlord";
            // 
            // checkBoxLimparConfig
            // 
            this.checkBoxLimparConfig.AutoSize = true;
            this.checkBoxLimparConfig.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLimparConfig.ForeColor = System.Drawing.Color.White;
            this.checkBoxLimparConfig.Location = new System.Drawing.Point(24, 256);
            this.checkBoxLimparConfig.Name = "checkBoxLimparConfig";
            this.checkBoxLimparConfig.Size = new System.Drawing.Size(180, 17);
            this.checkBoxLimparConfig.TabIndex = 8;
            this.checkBoxLimparConfig.Text = "Limpar arquivos de configuração";
            this.checkBoxLimparConfig.UseVisualStyleBackColor = false;
            // 
            // labelConfig
            // 
            this.labelConfig.BackColor = System.Drawing.Color.Transparent;
            this.labelConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfig.ForeColor = System.Drawing.Color.White;
            this.labelConfig.Location = new System.Drawing.Point(42, 276);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(469, 20);
            this.labelConfig.TabIndex = 9;
            this.labelConfig.Text = "Esta opção resetará configurações gerais do jogo, mas manterá os jogos salvos";
            // 
            // FormDiretorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1030, 538);
            this.Controls.Add(this.labelConfig);
            this.Controls.Add(this.checkBoxLimparConfig);
            this.Controls.Add(this.labelDiretorio);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.labelTraducao);
            this.Controls.Add(this.panelLogoBannerlord);
            this.Controls.Add(this.labelTextoSelecioneDiretorio);
            this.Controls.Add(this.buttonProximo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiretorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador Tradução Português Brasileiro Mount&Blade Bannerlord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonProximo;
        private Panel panelLogoBannerlord;
        private Label labelTraducao;
        private Label labelTextoSelecioneDiretorio;
        private Button buttonSair;
        private TextBox textBoxDirectory;
        private Button buttonBrowse;
        private Label labelDiretorio;
        private CheckBox checkBoxLimparConfig;
        private Label labelConfig;
    }
}