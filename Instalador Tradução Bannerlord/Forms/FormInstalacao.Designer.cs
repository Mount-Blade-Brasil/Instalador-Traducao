namespace Instalador_Tradução_Bannerlord.Forms
{
    partial class FormInstalacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstalacao));
            this.labelInstalando = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInstalando
            // 
            this.labelInstalando.AutoSize = true;
            this.labelInstalando.BackColor = System.Drawing.Color.Transparent;
            this.labelInstalando.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstalando.ForeColor = System.Drawing.Color.White;
            this.labelInstalando.Location = new System.Drawing.Point(103, 85);
            this.labelInstalando.Name = "labelInstalando";
            this.labelInstalando.Size = new System.Drawing.Size(150, 31);
            this.labelInstalando.TabIndex = 0;
            this.labelInstalando.Text = "Instalando";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aguarde...";
            // 
            // FormInstalação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Instalador_Tradução_Bannerlord.Properties.Resources.bground;
            this.ClientSize = new System.Drawing.Size(348, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInstalando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInstalação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInstalação";
            this.Load += new System.EventHandler(this.FormInstalação_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstalando;
        private System.Windows.Forms.Label label1;
    }
}