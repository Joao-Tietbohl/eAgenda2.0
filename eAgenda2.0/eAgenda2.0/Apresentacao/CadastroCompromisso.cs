using eAgenda2._0.Dominio;
using eAgenda2._0.Dominio.Compromisso;
using eAgenda2._0.Infra;
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
    public partial class CadastroCompromisso : Form
    {
        public Compromisso compromisso;
        

        public CadastroCompromisso(RepositorioContato repositorioContato)
        {
            InitializeComponent();
            compromisso = new Compromisso();

            cbContatos.Items.Clear();

            foreach  (Contato c in repositorioContato.SelecionarTodos())
            {
                cbContatos.Items.Add(c.Nome);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = txtAssunto.Text;
            compromisso.Local = txtLocal.Text;
            compromisso.DataCompromisso = datePicker.Value;
            compromisso.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
            compromisso.HoraTermino = TimeSpan.Parse(txtHoraTermino.Text);

        }

        
    }
}
