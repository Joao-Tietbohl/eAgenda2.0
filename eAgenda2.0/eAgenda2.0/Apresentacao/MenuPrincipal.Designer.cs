namespace eAgenda2._0.Apresentacao
{
    partial class MenuPrincipal
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
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelPrincipal.Location = new System.Drawing.Point(139, 23);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.painelPrincipal.Size = new System.Drawing.Size(580, 340);
            this.painelPrincipal.TabIndex = 0;
            // 
            // btnTarefa
            // 
            this.btnTarefa.Location = new System.Drawing.Point(12, 44);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(94, 37);
            this.btnTarefa.TabIndex = 1;
            this.btnTarefa.Text = "Tarefa";
            this.btnTarefa.UseVisualStyleBackColor = true;
            this.btnTarefa.Click += new System.EventHandler(this.btnTarefa_Click);
            // 
            // btnContato
            // 
            this.btnContato.Location = new System.Drawing.Point(12, 107);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(94, 37);
            this.btnContato.TabIndex = 2;
            this.btnContato.Text = "Contato";
            this.btnContato.UseVisualStyleBackColor = true;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.Location = new System.Drawing.Point(12, 170);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(94, 37);
            this.btnCompromisso.TabIndex = 3;
            this.btnCompromisso.Text = "Compromisso";
            this.btnCompromisso.UseVisualStyleBackColor = true;
            this.btnCompromisso.Click += new System.EventHandler(this.btnCompromisso_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 393);
            this.Controls.Add(this.btnCompromisso);
            this.Controls.Add(this.btnContato);
            this.Controls.Add(this.btnTarefa);
            this.Controls.Add(this.painelPrincipal);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Button btnTarefa;
        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.Button btnCompromisso;
    }
}