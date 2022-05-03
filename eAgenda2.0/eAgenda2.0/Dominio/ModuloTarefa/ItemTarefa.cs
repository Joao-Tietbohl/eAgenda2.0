﻿using System;

namespace eAgenda2._0.Dominio
{
    [Serializable]
    public class ItemTarefa
    {
        public string Titulo { get; set; }
        
        public bool Concluido { get; set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluido = true;
        }

        internal void MarcarPendente()
        {
            Concluido = false;
        }
    }
}
