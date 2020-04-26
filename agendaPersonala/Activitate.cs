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

        public Data Inceput { get; internal set; }
        public Data Sfarsit { get; internal set; }
        public List<Persoana> Persoane { get; internal set; }
    }
}