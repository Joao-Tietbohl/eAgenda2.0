using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0.Dominio.Compartilhado
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        void Editar(T entidade);
        void Excluir(T entidade);
        void Inserir(T novaEntidade);
        List<T> SelecionarTodos();
    }
}
