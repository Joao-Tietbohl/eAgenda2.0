namespace eAgenda2._0.Apresentacao
{
    partial class CadastroTarefas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbBaixa = new System.Windows.Forms.RadioButton();
            this.rbMedia = new System.Windows.Forms.RadioButton();
            this.rbAlta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(72, 17);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(61, 23);
            this.txtNumero.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(72, 53);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(352, 23);
            this.txtTitulo.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(271, 160);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(72, 39);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(352, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rbBaixa
            // 
            this.rbBaixa.AutoSize = true;
            this.rbBaixa.Location = new System.Drawing.Point(119, 104);
            this.rbBaixa.Name = "rbBaixa";
            this.rbBaixa.Size = new System.Drawing.Size(53, 19);
            this.rbBaixa.TabIndex = 6;
            this.rbBaixa.TabStop = true;
            this.rbBaixa.Text = "Baixa";
            this.rbBaixa.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            this.rbMedia.AutoSize = true;
            this.rbMedia.Location = new System.Drawing.Point(201, 104);
            this.rbMedia.Name = "rbMedia";
            this.rbMedia.Size = new System.Drawing.Size(65, 19);
            this.rbMedia.TabIndex = 7;
            this.rbMedia.TabStop = true;
            this.rbMedia.Text = "Normal";
            this.rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbAlta
            // 
            this.rbAlta.AutoSize = true;
            this.rbAlta.Location = new System.Drawing.Point(281, 104);
            this.rbAlta.Name = "rbAlta";
            this.rbAlta.Size = new System.Drawing.Size(46, 19);
            this.rbAlta.TabIndex = 8;
            this.rbAlta.TabStop = true;
            this.rbAlta.Text = "Alta";
            this.rbAlta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prioridade: ";
            // 
            // CadastroTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbAlta);
            this.Controls.Add(this.rbMedia);
            this.Controls.Add(this.rbBaixa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroTarefas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbBaixa;
        private System.Windows.Forms.RadioButton rbMedia;
        private System.Windows.Forms.RadioButton rbAlta;
        private System.Windows.Forms.Label label3;
    }
}