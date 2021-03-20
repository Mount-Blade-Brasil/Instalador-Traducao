namespace Instalador_Tradução_Bannerlord.Forms
{
    partial class FormInstalacaoFinalizada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstalacaoFinalizada));
            this.panelLogoBannerlord = new System.Windows.Forms.Panel();
            this.labelTraducao = new System.Windows.Forms.Label();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.labelTextoSelecioneDiretorio = new System.Windows.Forms.Label();
            this.panelDiscord = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelLogoBannerlord
            // 
            this.panelLogoBannerlord.BackColor = System.Drawing.Color.Transparent;
            this.panelLogoBannerlord.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.Logo_bannerlord;
            this.panelLogoBannerlord.Location = new System.Drawing.Point(12, 12);
            this.panelLogoBannerlord.Name = "panelLogoBannerlord";
            this.panelLogoBannerlord.Size = new System.Drawing.Size(202, 54);
            this.panelLogoBannerlord.TabIndex = 3;
            // 
            // labelTraducao
            // 
            this.labelTraducao.BackColor = System.Drawing.Color.Transparent;
            this.labelTraducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTraducao.ForeColor = System.Drawing.Color.White;
            this.labelTraducao.Location = new System.Drawing.Point(562, 61);
            this.labelTraducao.Name = "labelTraducao";
            this.labelTraducao.Size = new System.Drawing.Size(174, 23);
            this.labelTraducao.TabIndex = 4;
            this.labelTraducao.Text = "Tradução PT-BR";
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonFinalizar.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.b_finish;
            this.buttonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFinalizar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFinalizar.Location = new System.Drawing.Point(12, 457);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(345, 54);
            this.buttonFinalizar.TabIndex = 5;
            this.buttonFinalizar.UseVisualStyleBackColor = false;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // labelTextoSelecioneDiretorio
            // 
            this.labelTextoSelecioneDiretorio.BackColor = System.Drawing.Color.Transparent;
            this.labelTextoSelecioneDiretorio.ForeColor = System.Drawing.Color.White;
            this.labelTextoSelecioneDiretorio.Location = new System.Drawing.Point(28, 133);
            this.labelTextoSelecioneDiretorio.Name = "labelTextoSelecioneDiretorio";
            this.labelTextoSelecioneDiretorio.Size = new System.Drawing.Size(438, 119);
            this.labelTextoSelecioneDiretorio.TabIndex = 6;
            this.labelTextoSelecioneDiretorio.Text = resources.GetString("labelTextoSelecioneDiretorio.Text");
            // 
            // panelDiscord
            // 
            this.panelDiscord.BackColor = System.Drawing.Color.Transparent;
            this.panelDiscord.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.discord_link;
            this.panelDiscord.Location = new System.Drawing.Point(71, 295);
            this.panelDiscord.Name = "panelDiscord";
            this.panelDiscord.Size = new System.Drawing.Size(320, 88);
            this.panelDiscord.TabIndex = 7;
            this.panelDiscord.Click += new System.EventHandler(this.panelDiscord_Click);
            // 
            // FormInstalacaoFinalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1030, 538);
            this.Controls.Add(this.panelDiscord);
            this.Controls.Add(this.labelTextoSelecioneDiretorio);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.labelTraducao);
            this.Controls.Add(this.panelLogoBannerlord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInstalacaoFinalizada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInstalacaoFinalizada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogoBannerlord;
        private System.Windows.Forms.Label labelTraducao;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Label labelTextoSelecioneDiretorio;
        private System.Windows.Forms.Panel panelDiscord;
    }
}