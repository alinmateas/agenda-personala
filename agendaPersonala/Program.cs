using System;

namespace agendaPersonala
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana persoana = new Persoana();

            Agenda agenda = persoana.createAgenda();
            agenda.deleteActivity(persoana.Agenda.Activitati[0]);
            Activitate activitate = new Activitate("act_01", "spalat rufe");
            activitate.Inceput = new Data(2000,2,3,4,5);
            activitate.Sfarsit = new Data(2000,2,3,4,6);
            agenda.Activitati.Add(activitate);
            
        }

      
    }
}
