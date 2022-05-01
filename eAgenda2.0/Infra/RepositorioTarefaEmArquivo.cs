using eAgenda2._0.Dominio;
using eAgenda2._0.Dominio.Compartilhado;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda2._0.Infra
{
    public class RepositorioTarefaEmArquivo : IRepositorioTarefa
    {

        private readonly SerializadorTarefasEmJsonDotnet serializador;
        List<Tarefa> tarefas;
        private int contador = 0;

        public RepositorioTarefaEmArquivo(SerializadorTarefasEmJsonDotnet serializador)
        {
            this.serializador = serializador;

            tarefas = serializador.CarregarTarefasDoArquivo();

            if (tarefas.Count > 0)
                contador = tarefas.Max(x => x.Numero);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Inserir(EntidadeBase novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa as Tarefa);

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void Editar(EntidadeBase tarefa)
        {
            foreach (var item in tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo =  tarefa.Titulo;
                    break;
                }
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void Excluir(EntidadeBase tarefa)
        {
            tarefas.Remove(tarefa as Tarefa);

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AtualizarItens(Tarefa tarefaSelecionada,
            List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public List<Tarefa> SelecionarTarefasConcluidas()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() == 100).ToList();
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() < 100).ToList();
        }

        public void OrdenarTarefasPorPrioridade(List<Tarefa> listaTarefas)
        {
            List<Tarefa> prioridadeZero = new List<Tarefa>();
            List<Tarefa> prioridadeUm = new List<Tarefa>();
            List<Tarefa> prioridadeDois = new List<Tarefa>();


            foreach (Tarefa tarefa in listaTarefas)
            {
                if(tarefa.Prioridade == PrioridadeTarefa.Baixa)
                    prioridadeZero.Add(tarefa);

                if(tarefa.Prioridade == PrioridadeTarefa.Normal)
                    prioridadeUm.Add(tarefa);

                if(tarefa.Prioridade == PrioridadeTarefa.Alta)
                    prioridadeDois.Add(tarefa);
            }

            listaTarefas.Clear();
            listaTarefas.AddRange(prioridadeDois);
            listaTarefas.AddRange(prioridadeUm);
            listaTarefas.AddRange(prioridadeZero);
        }

     
    }
}
