using eAgenda2._0.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda2._0.Dominio.Compromisso
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public string Local { get; set; }

        private DateTime _dataCompromisso;
        public DateTime DataCompromisso { get => _dataCompromisso.Add(HoraInicio); set => _dataCompromisso = value; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public Contato Contato { get; }
    }
}
