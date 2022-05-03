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
    public partial class MenuPrincipal : Form
    {
        RepositorioTarefa repositorioTarefa;
        ListagemTarefas pListagemtarefa;

        RepositorioContato repositorioContato;
        ListagemContato pListagemContato;

        RepositorioCompromisso repositorioCompromisso;
        ListagemCompromisso pListagemCompromisso;


        public MenuPrincipal()
        {
            InitializeComponent();

           
            repositorioTarefa = new RepositorioTarefa();
            pListagemtarefa = new ListagemTarefas();

            repositorioContato = new RepositorioContato();
            pListagemContato = new ListagemContato();

            repositorioCompromisso = new RepositorioCompromisso();
            pListagemCompromisso = new ListagemCompromisso(repositorioContato);
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {

            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(pListagemtarefa);

        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(pListagemContato);
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(pListagemCompromisso);
        }
    }
}
