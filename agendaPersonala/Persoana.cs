using System;
using System.Collections.Generic;

namespace agendaPersonala
{
    public class Persoana
    {

        private string nume;
        private string prenume;
        private Data dataDeNastere; 
        public Agenda Agenda { get; set; }

        public Persoana(string nume, string prenume,Data dataDeNastere)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.dataDeNastere = dataDeNastere;
        }

       public Persoana()
        {

        }

        public List<Activitate> hasActivitiesBetween(Data Inceput,Data Sfarsit)
        {
            List<Activitate> allActivities = Agenda.Activitati;
            List<Activitate> result = new List<Activitate>();

            foreach (Activitate activitate in allActivities)
            {
                if (activitate.Inceput.An > Inceput.An && activitate.Sfarsit.An < Sfarsit.An)
                {
                    if (activitate.Inceput.Luna > Inceput.Luna && activitate.Sfarsit.Luna < Sfarsit.Luna)
                    {
                        if (activitate.Inceput.Zi > Inceput.Zi && activitate.Sfarsit.Zi < Sfarsit.Zi)
                        {
                            if (activitate.Inceput.Ora > Inceput.Ora && activitate.Sfarsit.Ora < Sfarsit.Ora)
                            {
                                if (activitate.Inceput.Minut > Inceput.Minut && activitate.Sfarsit.Minut < Sfarsit.Minut)
                                {
                                    result.Add(activitate);
                                }
                            }
                        }
                    }
                }
               
            }

            return result;
        }

        public bool hasActivitiesBetweenHours(int InceputOra,int InceputMinut, int SfarsitOra, int SfarsitMinut)
        {
            List<Activitate> allActivities = Agenda.Activitati;
            List<Activitate> result = new List<Activitate>();

            foreach (Activitate activitate in allActivities)
            {
                {
                    if (activitate.Inceput.Ora > InceputOra && activitate.Sfarsit.Ora < SfarsitOra)
                    {
                        if (activitate.Inceput.Minut > InceputMinut && activitate.Sfarsit.Minut < SfarsitMinut)
                        {
                            result.Add(activitate);
                        }
                    }
                }

            }

            return result.Count != 0;
        }

        internal void deleteAgenda()
        {
            this.Agenda = null;
        }

        public Agenda createAgenda()
        {
            Agenda agendaPrima = new Agenda();
            Data inceput = new Data(2020, 10, 19, 12, 45);
            Data sfarsit = new Data(2020, 10, 19, 13, 45);
            Activitate activitate = GenerateActivity(this, inceput, sfarsit);
            List<Activitate> listaToAgenda = new List<Activitate>
            {
                activitate
            };
            agendaPrima.Activitati = listaToAgenda;
            Agenda = agendaPrima;
            agendaPrima.Persoana = this;

            return agendaPrima;
        }

       
        private static Activitate GenerateActivity(Persoana p, Data inceput, Data sfarsit)
        {
            Activitate activitate = new Activitate("Activitate_01", "spalat rufe");
            activitate.Inceput = inceput;
            activitate.Sfarsit = sfarsit;
            List<Persoana> persoanteToActivitate = new List<Persoana>
            {
                p
            };
            activitate.Persoane = persoanteToActivitate;
            return activitate;
        }


    }
}