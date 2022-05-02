using eAgenda2._0.Dominio;
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
    public partial class ListagemTarefasPainel : UserControl
    {
        private RepositorioTarefa repositorioTarefa;

        public ListagemTarefasPainel()
        {
            InitializeComponent();
            SerializadorTarefasEmJsonDotnet serializador = new SerializadorTarefasEmJsonDotnet();

            repositorioTarefa = new RepositorioTarefa(serializador);
        
            CarregarTarefas();
        }

        private void ListagemTarefasTela_Load(object sender, EventArgs e)
        {

        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas = repositorioTarefa.SelecionarTarefasConcluidas();
            repositorioTarefa.OrdenarTarefasPorPrioridade(tarefasConcluidas);


            listTarefasConcluidas.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                listTarefasConcluidas.Items.Add(t);
            }

            List<Tarefa> tarefasPendentes = repositorioTarefa.SelecionarTarefasPendentes();
            repositorioTarefa.OrdenarTarefasPorPrioridade(tarefasPendentes);

            listTarefasPendentes.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                listTarefasPendentes.Items.Add(t);
            }
        }

        private void btnInserir_Click(object sender, System.EventArgs e)
        {
            CadastroTarefas tela = new CadastroTarefas();
            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            if (string.IsNullOrEmpty(tela.Tarefa.Titulo))
            {
                MessageBox.Show("Titulo não pode estar vazio",
              "Cadastro de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            bool existeTitulo = repositorioTarefa.SelecionarTodos().Exists(x => x.Titulo == tela.Tarefa.Titulo);

            if (existeTitulo == true)
            {

                MessageBox.Show("Titulo deve ser único",
               "Cadastro de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tela.Tarefa.Prioridade == null)
                tela.Tarefa.Prioridade = PrioridadeTarefa.Baixa;




            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {

            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroTarefas tela = new CadastroTarefas();

            tela.Tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {

            Tarefa tarefaPendenteSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;
            Tarefa tarefaConcluidaSelecionada = (Tarefa)listTarefasConcluidas.SelectedItem;

            if (tarefaPendenteSelecionada != null)
                ExcluirTarefa(tarefaPendenteSelecionada);


            if (tarefaConcluidaSelecionada != null)
                ExcluirTarefa(tarefaConcluidaSelecionada);

            if (tarefaPendenteSelecionada == null && tarefaConcluidaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void ExcluirTarefa(Tarefa tarefaSelecionada)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }

        private void btnCadastrarItens_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }
        }

        private void btnAtualizarItens_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
        }
    }
}
