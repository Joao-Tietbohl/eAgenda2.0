namespace eAgenda2._0.Apresentacao
{
    partial class ListagemCompromisso
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listCompromissosFuturos = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listCompromissosPassados = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 256);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listCompromissosFuturos);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compromissos Futuros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listCompromissosFuturos
            // 
            this.listCompromissosFuturos.FormattingEnabled = true;
            this.listCompromissosFuturos.ItemHeight = 15;
            this.listCompromissosFuturos.Location = new System.Drawing.Point(6, 15);
            this.listCompromissosFuturos.Name = "listCompromissosFuturos";
            this.listCompromissosFuturos.Size = new System.Drawing.Size(508, 199);
            this.listCompromissosFuturos.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listCompromissosPassados);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compromissos Passados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listCompromissosPassados
            // 
            this.listCompromissosPassados.FormattingEnabled = true;
            this.listCompromissosPassados.ItemHeight = 15;
            this.listCompromissosPassados.Location = new System.Drawing.Point(10, 15);
            this.listCompromissosPassados.Name = "listCompromissosPassados";
            this.listCompromissosPassados.Size = new System.Drawing.Size(508, 199);
            this.listCompromissosPassados.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(193, 20);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 38);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(112, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 38);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(34, 20);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(72, 39);
            this.btnInserir.TabIndex = 16;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // ListagemCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Name = "ListagemCompromisso";
            this.Size = new System.Drawing.Size(580, 340);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listCompromissosFuturos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listCompromissosPassados;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
    }
}
