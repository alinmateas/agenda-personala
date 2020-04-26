using System;
using System.Collections.Generic;
using System.Text;

namespace agendaPersonala
{
    public class Data
    {
        public int Ora { get; internal set; }
        public int Minut { get; internal set; } 
        public int An { get; internal set; }
        public int Zi { get; internal set; }
        public int Luna{ get; internal set; }
    
        public Data(int an, int luna, int zi, int ora, int minut) {
            this.An = an;
            this.Luna = luna;
            this.Zi = zi;
            this.Ora = ora;
            this.Minut = minut;
        }
    }
}
