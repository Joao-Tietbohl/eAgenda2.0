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
        SerializadorTarefasEmJsonDotnet serializadorTarefas;
        ListagemTarefasPainel pListagemtarefa;

        public MenuPrincipal()
        {
            InitializeComponent();

            serializadorTarefas = new SerializadorTarefasEmJsonDotnet();
            repositorioTarefa = new RepositorioTarefa(serializadorTarefas);
            pListagemtarefa = new ListagemTarefasPainel();
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {

            painelPrincipal.Controls.Clear();
            painelPrincipal.Controls.Add(pListagemtarefa);

        }

       
    }
}
