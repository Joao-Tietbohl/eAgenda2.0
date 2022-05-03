namespace eAgenda2._0.Apresentacao
{
    partial class CadastroCompromisso
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.txtHoraTermino = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbContatos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assunto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horario de início:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horario de Termino:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(105, 33);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(198, 23);
            this.txtAssunto.TabIndex = 5;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(105, 67);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(198, 23);
            this.txtLocal.TabIndex = 6;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(105, 101);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 23);
            this.datePicker.TabIndex = 7;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(146, 135);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(110, 23);
            this.txtHoraInicio.TabIndex = 8;
            // 
            // txtHoraTermino
            // 
            this.txtHoraTermino.Location = new System.Drawing.Point(146, 165);
            this.txtHoraTermino.Name = "txtHoraTermino";
            this.txtHoraTermino.Size = new System.Drawing.Size(110, 23);
            this.txtHoraTermino.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(242, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(51, 241);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Cadastrar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contato:";
            // 
            // cbContatos
            // 
            this.cbContatos.FormattingEnabled = true;
            this.cbContatos.Location = new System.Drawing.Point(114, 198);
            this.cbContatos.Name = "cbContatos";
            this.cbContatos.Size = new System.Drawing.Size(142, 23);
            this.cbContatos.TabIndex = 13;
            // 
            // CadastroCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 286);
            this.Controls.Add(this.cbContatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtHoraTermino);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCompromisso";
            this.Text = "CadastroCompromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtHoraTermino;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbContatos;
    }
}