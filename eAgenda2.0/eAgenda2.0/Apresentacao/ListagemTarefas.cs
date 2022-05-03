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
    public partial class ListagemTarefas : UserControl
    {
        private RepositorioTarefa repositorioTarefa;

        public ListagemTarefas()
        {
            InitializeComponent();
   
            repositorioTarefa = new RepositorioTarefa();
        
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
            

            DialogResult resultado = tela.ShowDialog();

            string validacao = ValidarTarefa(tela.tarefa);

            if (validacao != "")
            {
                MessageBox.Show(validacao,
              "Cadastro de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tela.tarefa.Prioridade == null)
                tela.tarefa.Prioridade = PrioridadeTarefa.Baixa;


            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.tarefa);
                CarregarTarefas();
            }
        }

        private string ValidarTarefa(Tarefa tarefa)
        {
            string validacao = "";

            if (tarefa.Titulo == null)
                validacao = "Tarefa precisa de Título";
            
            bool existeTitulo = repositorioTarefa.SelecionarTodos().Exists(x => x.Titulo == tarefa.Titulo);

            if (existeTitulo == true)
                validacao += "\n Título da tarefa precisa ser único";


            return validacao;
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

            tela.tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            string validacao = ValidarTarefa(tela.tarefa);

            if (validacao != "")
            {
                MessageBox.Show(validacao,
              "Cadastro de Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.tarefa);
                CarregarTarefas();
            }
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {

            Tarefa tarefaPendenteSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;
            Tarefa tarefaConcluidaSelecionada = (Tarefa)listTarefasConcluidas.SelectedItem;

            if (tarefaPendenteSelecionada == null && tarefaConcluidaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (tarefaPendenteSelecionada != null)
                ExcluirTarefa(tarefaPendenteSelecionada);


            if (tarefaConcluidaSelecionada != null)
                ExcluirTarefa(tarefaConcluidaSelecionada);

           
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
