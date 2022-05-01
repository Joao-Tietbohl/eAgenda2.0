using eAgenda2._0.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0.Dominio.Compartilhado
{
    public class RepositorioBase<T> : IRepositorio<T> where T : EntidadeBase
    {
        private readonly SerializadorTarefasEmJsonDotnet serializador;

        protected readonly List<T> registros;

        protected int contadorId;

        public RepositorioBase()
        {
            registros = new List<T>();
        }

        public void Editar(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Inserir(T novaEntidade)
        {
            throw new NotImplementedException();
        }

        public List<T> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
