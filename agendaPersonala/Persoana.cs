using System;
using System.Collections.Generic;

namespace agendaPersonala
{
    public class Persoana
    {

        private string nume;
        private string prenume;
        private Data dataDeNastere; 
        public Agenda Agenda { get; internal set; }

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
            agendaPrima.Activitati.Add(activitate);
            this.Agenda = agendaPrima;
            agendaPrima.Persoana = this;

            return agendaPrima;
        }

       
        private static Activitate GenerateActivity(Persoana p, Data inceput, Data sfarsit)
        {
            Activitate activitate = new Activitate("Activitate_01", "spalat rufe");
            activitate.Inceput = new Data(2020, 10, 19, 12, 45);
            activitate.Sfarsit = new Data(2020, 10, 19, 13, 45);
            activitate.Persoane.Add(p);
            return activitate;
        }


    }
}