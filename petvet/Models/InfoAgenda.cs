using System;
using System.Collections.Generic;

namespace petvet.Models
{
    public class InfoAgenda
    {
        private static List<Agenda> lista = new List<Agenda>();

        public void Incluir(Agenda petvet)
        {
            lista.Add(petvet);
        }

        public List<Agenda> Listar()
        {
            return lista;
        }
        
        
    }
}