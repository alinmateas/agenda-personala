using System;

namespace agendaPersonala
{
    public class Activitate
    {
        private string nume;
        private string descriere;
       

        public Activitate()
        {
        }

        public Data Inceput { get; internal set; }
        public Data Sfarsit { get; internal set; }
        public string Nume { get; internal set; }
    }
}