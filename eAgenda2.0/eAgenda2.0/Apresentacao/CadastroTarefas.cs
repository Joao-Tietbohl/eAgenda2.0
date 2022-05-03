using eAgenda2._0.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda2._0.Apresentacao
{
    public partial class CadastroTarefas : Form
    {
        public Tarefa tarefa;
        

        public CadastroTarefas()
        {
            InitializeComponent();
            tarefa = new Tarefa();
           
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.Numero.ToString();
                txtTitulo.Text = tarefa.Titulo;
            }
        }      

        private void btnGravar_Click(object sender, EventArgs e)
        {
        
            tarefa.Titulo = txtTitulo.Text;

            if (rbBaixa.Checked == true)
                tarefa.Prioridade = PrioridadeTarefa.Baixa;

            if (rbMedia.Checked == true)
                tarefa.Prioridade = PrioridadeTarefa.Normal;

            if (rbAlta.Checked == true)
                tarefa.Prioridade = PrioridadeTarefa.Alta;
        }
    }
}
