using System;
using System.Collections.Generic;

namespace agendaPersonala
{
    public class Activitate
    {
        private string descriere;
        public string nume;
       
        public Activitate()
        {
        }

        public Activitate(string nume, string descriere)
        {
            this.nume = nume;
            this.descriere = descriere;
        }

        public Data Inceput { get; set; }
        public Data Sfarsit { get; set; }
        public List<Persoana> Persoane { get; set; }
    }
}