using System.Collections.Generic;

namespace agendaPersonala
{
    public class Agenda
    {
        public Agenda()
        {
            
        }

        public List<Activitate> Activitati { get;  set; }
        public Persoana Persoana { get; internal set; }

        public void deleteActivity(Activitate activitateDeSters)
        {
            List<Activitate> allActivities = Activitati;

            for (int i = 0; i < allActivities.Count; i++)
            {
                if (allActivities[i].nume.Contains(activitateDeSters.nume))
                {
                    allActivities[i] = null;
                }
            }
        }

    }
}