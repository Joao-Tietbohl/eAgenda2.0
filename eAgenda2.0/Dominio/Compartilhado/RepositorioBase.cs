using eAgenda2._0.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0.Dominio.Compartilhado
{
    public class RepositorioBase<T> where T : EntidadeBase
    {
        private readonly SerializadorTarefasEmJsonDotnet serializador;

        protected readonly List<T> registros;

        protected int contadorId;

      

        public RepositorioBase()
        {
            registros = new List<T>();
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }
    }
}
