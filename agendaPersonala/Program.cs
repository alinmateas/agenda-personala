using System;

namespace agendaPersonala
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            Persoana persoana = new Persoana(agenda);
            Activitate activitate = new Activitate();
        }
    }
}
