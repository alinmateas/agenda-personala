using System;
using System.Collections.Generic;

namespace agendaPersonala
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana persoana = new Persoana();
            Persoana persoana2 = new Persoana();

            Agenda agenda2 = persoana2.createAgenda();
            Agenda agenda = persoana.createAgenda();
            Activitate activitate, activitate2, activitate3, activitate4, activitate5;
            InitActivities(out activitate, out activitate2, out activitate3, out activitate4, out activitate5);

            List<Activitate> listaToActivitati = new List<Activitate>
            {

                activitate2,
                activitate,
                activitate3
            };
            agenda.Activitati = listaToActivitati;

            List<Activitate> listaToActivitati2 = new List<Activitate>
            {
                activitate5,
                activitate4,
                activitate2

            };
            agenda2.Activitati = listaToActivitati2;

            List<Activitate> activitatiGasite = agenda.Cautare("act_0");

            //persoana.deleteAgenda();
            //agenda.deleteActivity(persoana.Agenda.Activitati[0]);

            ListaPersoane lista = new ListaPersoane();
            List<Persoana> listaToListaPersoane = new List<Persoana>
            {
                persoana
            };
            lista.Persoane = listaToListaPersoane;
            List<Persoana> persoaneImplicate = new List<Persoana>
            {
                persoana,
                persoana2
            };
            string interval = lista.IntervalTimpLiber(persoaneImplicate, 8, 18);
        }

       

        private static void InitActivities(out Activitate activitate, out Activitate activitate2, out Activitate activitate3, out Activitate activitate4, out Activitate activitate5)
        {
            activitate = new Activitate("act_01", "spalat rufe");
            activitate.Inceput = new Data(2000, 2, 3, 14, 15);
            activitate.Sfarsit = new Data(2000, 2, 3, 14, 25);
            activitate2 = new Activitate("act_012", "spalat altceva");
            activitate2.Inceput = new Data(2000, 2, 3, 12, 35);
            activitate2.Sfarsit = new Data(2000, 2, 3, 14, 10);
            activitate3 = new Activitate("act_013", "spalat animale");
            activitate3.Inceput = new Data(2000, 2, 3, 16, 25);
            activitate3.Sfarsit = new Data(2000, 2, 3, 17, 10);
            activitate4 = new Activitate("act_014", "spalat animale inca o data");
            activitate4.Inceput = new Data(2000, 2, 3, 10, 35);
            activitate4.Sfarsit = new Data(2000, 2, 3, 11, 21);
            activitate5 = new Activitate("act_015", "spalat mai multe aniamle");
            activitate5.Inceput = new Data(2000, 2, 3, 8, 35);
            activitate5.Sfarsit = new Data(2000, 2, 3, 9, 10);
        }

    }
}
