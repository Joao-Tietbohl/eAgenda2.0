using eAgenda2._0.Dominio;
using eAgenda2._0.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0.Infra
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        private int contador = 0;

        public RepositorioContato()
        {

            if (registros.Count > 0)
                contador = registros.Max(x => x.Numero);
        }

        public List<Contato> SelecionarTodos()
        {
            return registros;
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;
            registros.Add(novoContato);


        }

        public void Editar(Contato contato)
        {
            foreach (var item in registros)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;
                    item.Email = contato.Email;
                    item.Telefone = contato.Telefone;
                    item.Empresa = contato.Empresa;
                    item.Cargo = contato.Cargo;
                    break;
                }
            }

        }

        internal void OrdenarPorCargo(List<Contato> contatos)
        {
            contatos.Sort((x, y) => string.Compare(x.Cargo, y.Cargo));

        }

        public void Excluir(Contato contato)
        {
            registros.Remove(contato);

        }
    }
}
