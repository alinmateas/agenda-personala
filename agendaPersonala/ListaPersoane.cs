using System;
using System.Collections.Generic;
using System.Text;

namespace agendaPersonala
{
    public class ListaPersoane
    {
        public List<Persoana> Persoane { get; set; }

        public string IntervalTimpLiber(List<Persoana> persoaneImplicate,int limitaInceput, int limitaSfarsit)
        {
            Data data = new Data();
            StringBuilder[] timpActivitati = new StringBuilder[15];
            List<List<StringBuilder>> timpuriLibere = new List<List<StringBuilder>>();
            StringBuilder[] timpLiber = new StringBuilder[15];
            for(int i = 0; i < timpActivitati.Length; i++)
            {
                timpActivitati[i] = new StringBuilder();
                timpLiber[i] = new StringBuilder();
            }

            for (int i = 0; i < persoaneImplicate.Count; i++)
            {
                List<Activitate> listaActivitati = persoaneImplicate[i].Agenda.Activitati;

                bool primaActivitate = true;
                int ultimaActivitateOra = 0;
                int ultimaActivitateMinut = 0;
                List<StringBuilder> listaInterior = new List<StringBuilder>();
                
                foreach (Activitate activitate in listaActivitati)//presupunem ca orele activitatilor sunt sortate
                {
                    StringBuilder sb = new StringBuilder();
                    if (primaActivitate)
                    {
                        sb.Append(limitaInceput.ToString() + ":" + "00" + " - " + activitate.Inceput.Ora.ToString() + ":" + activitate.Inceput.Minut.ToString());primaActivitate = false;
                        ultimaActivitateOra = activitate.Sfarsit.Ora;
                        ultimaActivitateMinut = activitate.Sfarsit.Minut;
                    }
                    else
                    { 
                        sb.Append(ultimaActivitateOra.ToString() + ":" + ultimaActivitateMinut.ToString() + " - " + activitate.Inceput.Ora.ToString() + ":" + activitate.Inceput.Minut.ToString()); ultimaActivitateOra = activitate.Sfarsit.Ora;
                    ultimaActivitateMinut = activitate.Sfarsit.Minut;
                    }

                    listaInterior.Add(sb);
                }
                listaInterior.Add(new StringBuilder().Append(ultimaActivitateOra.ToString() + ":" + ultimaActivitateMinut.ToString() + " - " + limitaSfarsit.ToString() + ":" + "00"));

                timpuriLibere.Add(listaInterior);
            }

            for (int i = 0; i < persoaneImplicate.Count - 1; i++)
            {
                int acts = persoaneImplicate[i].Agenda.Activitati.Count;
                int oraI = 0;
                int minutI = 0; 
                int oraS = 0;
                int minutS = 0;
                for (int k = 0; k < acts; k++)
                {
                    bool oke = true;
                    for (int contor = 0; contor < timpuriLibere[i][k].Length; contor++)
                    {
                        if (timpuriLibere[i][k][contor] == '-')
                        {   
                            minutI = int.Parse(timpuriLibere[i][k].ToString(contor - 3, 2));
                        }
                        if (timpuriLibere[i][k][contor] == ':' && !oke)
                        {
                            oraS = int.Parse(timpuriLibere[i][k].ToString(contor - 2, 2));
                            minutS = int.Parse(timpuriLibere[i][k].ToString(contor + 1, 2));
                        }
                        if (timpuriLibere[i][k][contor] == ':' && oke)
                        {
                            oraI = int.Parse(timpuriLibere[i][k].ToString(0, contor));
                            oke = false;
                        }
                
                    }


                    bool ok = true;
                    for (int j = i + 1; j < persoaneImplicate.Count; j++)
                    {
                        if (persoaneImplicate[j].hasActivitiesBetweenHours(oraI, minutI, oraS, minutS)) ok = false;

                    }
                    if (ok) return "Grupul de persoane este liber intre " + oraI + ":" + minutI + "-" + oraS + ":" + minutS;

                }
             
            }

            return "Nu exista un interval de timp liber pentru aces grup";
        }
    }
}