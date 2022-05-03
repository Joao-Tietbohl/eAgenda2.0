using eAgenda2._0.Dominio;
using eAgenda2._0.Dominio.Compartilhado;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda2._0.Infra
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {

        private int contador = 0;

        public RepositorioTarefa()
        {
         
            if (registros.Count > 0)
                contador = registros.Max(x => x.Numero);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return registros;
        }

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            registros.Add(novaTarefa);


        }

        public void Editar(Tarefa tarefa)
        {
            foreach (var item in registros)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo =  tarefa.Titulo;
                    item.Prioridade = tarefa.Prioridade;
                    break;
                }
            }
       
        }

        public void Excluir(Tarefa tarefa)
        {
            registros.Remove(tarefa);

        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

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

           
        }

        public List<Tarefa> SelecionarTarefasConcluidas()
        {
            return registros.Where(x => x.CalcularPercentualConcluido() == 100).ToList();
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            return registros.Where(x => x.CalcularPercentualConcluido() < 100).ToList();
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
