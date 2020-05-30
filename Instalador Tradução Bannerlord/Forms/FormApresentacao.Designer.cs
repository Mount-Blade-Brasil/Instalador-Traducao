namespace Instalador_Tradução_Bannerlord.Forms
{
    partial class FormApresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApresentacao));
            this.panelLogoBannerlord = new System.Windows.Forms.Panel();
            this.labelTraducao = new System.Windows.Forms.Label();
            this.buttonProximo = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelTextoSelecioneDiretorio = new System.Windows.Forms.Label();
            this.labelCreditos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.labelTraducao.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTraducao.ForeColor = System.Drawing.Color.White;
            this.labelTraducao.Location = new System.Drawing.Point(562, 61);
            this.labelTraducao.Name = "labelTraducao";
            this.labelTraducao.Size = new System.Drawing.Size(174, 23);
            this.labelTraducao.TabIndex = 4;
            this.labelTraducao.Text = "Tradução PT-BR";
            // 
            // buttonProximo
            // 
            this.buttonProximo.BackColor = System.Drawing.Color.Transparent;
            this.buttonProximo.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.botao_proximo;
            this.buttonProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProximo.ForeColor = System.Drawing.Color.Transparent;
            this.buttonProximo.Location = new System.Drawing.Point(12, 457);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(345, 54);
            this.buttonProximo.TabIndex = 5;
            this.buttonProximo.UseVisualStyleBackColor = false;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            this.buttonProximo.MouseLeave += new System.EventHandler(this.buttonProximo_MouseLeave);
            this.buttonProximo.MouseHover += new System.EventHandler(this.buttonProximo_MouseHover);
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
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "X";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelTextoSelecioneDiretorio
            // 
            this.labelTextoSelecioneDiretorio.BackColor = System.Drawing.Color.Transparent;
            this.labelTextoSelecioneDiretorio.ForeColor = System.Drawing.Color.White;
            this.labelTextoSelecioneDiretorio.Location = new System.Drawing.Point(12, 114);
            this.labelTextoSelecioneDiretorio.Name = "labelTextoSelecioneDiretorio";
            this.labelTextoSelecioneDiretorio.Size = new System.Drawing.Size(465, 22);
            this.labelTextoSelecioneDiretorio.TabIndex = 7;
            this.labelTextoSelecioneDiretorio.Text = "Bem vindo ao instalador da Tradução do Mount and Blade Bannerlord para Português " +
    "Brasileiro!";
            // 
            // labelCreditos
            // 
            this.labelCreditos.BackColor = System.Drawing.Color.Transparent;
            this.labelCreditos.ForeColor = System.Drawing.Color.White;
            this.labelCreditos.Location = new System.Drawing.Point(12, 152);
            this.labelCreditos.Name = "labelCreditos";
            this.labelCreditos.Size = new System.Drawing.Size(179, 263);
            this.labelCreditos.TabIndex = 8;
            this.labelCreditos.Text = resources.GetString("labelCreditos.Text");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 282);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormApresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1030, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCreditos);
            this.Controls.Add(this.labelTextoSelecioneDiretorio);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonProximo);
            this.Controls.Add(this.labelTraducao);
            this.Controls.Add(this.panelLogoBannerlord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApresentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInstalacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogoBannerlord;
        private System.Windows.Forms.Label labelTraducao;
        private System.Windows.Forms.Button buttonProximo;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelTextoSelecioneDiretorio;
        private System.Windows.Forms.Label labelCreditos;
        private System.Windows.Forms.Label label1;
    }
}