using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProRizeniAut
{
    class Program
    {
        static void Main(string[] args)
        {
            Trasa t = new Trasa();
            AV a1 = new AV(150, t.)

            
        }
    }


    public class Trasa
    {
        List<string> L_Trasa = new List<string>();


        void GeneraceTrasy()
        {
            
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                int c = random.Next(1, 4);
                for (int j = 0; j < 3; j++)
                {
                    if (c == 1) L_Trasa.Add("T");
                    else if (c == 2) L_Trasa.Add("M");
                    else if (c == 3)
                    {
                        L_Trasa.Add("C");
                        break;
                    }
                }
                
            }
        }
        

    }

    public enum Teren { most, tunel, silnice }

    


    class SMD
    {
        public enum Pocasi { dest, slunecno, kroupy, zatazeno, bourka }
    }

    class RC
    {

    }

    public class AV
    {
        double Rychlost { get; set; }
        double Delka_trasy { get; set; }
        Teren teren { get; set; }
        bool Svetla { get; set; }

        List<string> L_Trasa;

        public AV(double rychlost, double delka_trasy, Teren t, bool svetla, List<string> l_trasa)        {            Rychlost = rychlost;            Delka_trasy = delka_trasy;            teren = t;            Svetla = svetla;            L_Trasa = l_trasa;        }
        //public delegate void Vozidlo(double rychlost, double delka_trasy, Teren t, bool svetla, List<string> l_trasa);
    }
    


}
