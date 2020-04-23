using System;
using System.Collections.Generic;

namespace agendaPersonala
{
    public class Persoana
    {

        private string nume;
        private string prenume;
        private DateTime dataDeNastere; 
        private Agenda agenda;

        public Persoana(Agenda agenda)
        {
            this.agenda = agenda;
        }

        public List<Activitate> hasActivitiesBetween(Data Inceput,Data Sfarsit)
        {
            List<Activitate> allActivities = agenda.Activitati;
            List<Activitate> result = new List<Activitate>();

            foreach(Activitate activitate in allActivities)
            {
                if(activitate.Inceput.Ora > Inceput.Ora && activitate.Sfarsit.Ora < Sfarsit.Ora)
                {
                    if(activitate.Inceput.Minut > Inceput.Minut && activitate.Sfarsit.Minut < Sfarsit.Minut)
                    {
                        result.Add(activitate);
                    }
                }
            }

            return result;
        }

    }
}