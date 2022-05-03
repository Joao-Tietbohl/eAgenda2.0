using eAgenda2._0.Dominio.Compartilhado;
using eAgenda2._0.Dominio.Compromisso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0.Infra
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {

        private int contador = 0;

        public RepositorioCompromisso()
        {

            if (registros.Count > 0)
                contador = registros.Max(x => x.Numero);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return registros;
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            novoCompromisso.Numero = ++contador;
            registros.Add(novoCompromisso);


        }

        public void Editar(Compromisso compromisso)
        {
            foreach (var item in registros)
            {
                if (item.Numero == compromisso.Numero)
                {
                   
                    break;
                }
            }

        }

        internal List<Compromisso> SelecionarCompromissosFuturos()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach  (Compromisso c in registros)
            {
                if(c.DataCompromisso > DateTime.Now)
                    compromissosFuturos.Add(c);
            }

            return compromissosFuturos;
        }

        public void Excluir(Compromisso compromisso)
        {
            registros.Remove(compromisso);

        }

        internal List<Compromisso> SelecionarCompromissosPassados()
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (Compromisso c in registros)
            {
                if (c.DataCompromisso < DateTime.Now)
                    compromissosPassados.Add(c);
            }

            return compromissosPassados;
        }
    }
}
