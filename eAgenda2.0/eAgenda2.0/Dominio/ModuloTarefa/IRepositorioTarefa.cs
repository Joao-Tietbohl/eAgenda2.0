using eAgenda2._0.Dominio.Compartilhado;
using System.Collections.Generic;

namespace eAgenda2._0.Dominio
{
    public interface IRepositorioTarefa : IRepositorio<Tarefa>
    {
        void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens);
        void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes);
        void Editar(EntidadeBase tarefa);
        void Excluir(EntidadeBase tarefa);
        void Inserir(EntidadeBase novaTarefa);
        List<Tarefa> SelecionarTodos();

        List<Tarefa> SelecionarTarefasConcluidas();

        List<Tarefa> SelecionarTarefasPendentes();
        void OrdenarTarefasPorPrioridade(List<Tarefa> listaTarefas);
    }
}