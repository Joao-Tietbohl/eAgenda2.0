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
    public partial class ListagemCompromisso : UserControl
    {
        RepositorioCompromisso repositorioCompromisso;
        RepositorioContato repositorioContato;
        
        public ListagemCompromisso(RepositorioContato repositorioContato)
        {
            InitializeComponent();
            this.repositorioContato = repositorioContato;

            repositorioCompromisso = new RepositorioCompromisso();

            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissosFuturos = repositorioCompromisso.SelecionarCompromissosFuturos();
    
            listCompromissosFuturos.Items.Clear();

            foreach (Compromisso c in compromissosFuturos)
            {
                listCompromissosFuturos.Items.Add(c);
            }

            List<Compromisso> compromissosPassados = repositorioCompromisso.SelecionarCompromissosPassados();
           

            listCompromissosPassados.Items.Clear();

            foreach (Compromisso c in compromissosPassados)
            {
                listCompromissosPassados.Items.Add(c);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroCompromisso tela = new CadastroCompromisso(repositorioContato);
           
            DialogResult resultado = tela.ShowDialog();

            string validacao = ValidarCompromisso(tela.compromisso);

            if (validacao != "")
            {
                MessageBox.Show(validacao,
              "Cadastro de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Inserir(tela.compromisso);
                CarregarCompromissos();
            }
        }

        private string ValidarCompromisso(Compromisso compromisso)
        {
            throw new NotImplementedException();
        }
    }
    
}
