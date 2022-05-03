using eAgenda2._0.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0.Dominio
{
    public class Contato : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }


        public override string ToString()
        {
            return $"Numero {Numero}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}, Empresa: {Empresa}, Cargo: {Cargo} ";
        }
    }
}
