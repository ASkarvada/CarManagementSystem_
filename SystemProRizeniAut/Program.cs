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



        }
    }


    class Trasa
    {
        
        

    }

    public enum Teren { most, tunel, silnice }

    public List<Trasa> Tr = new List<Trasa>();

    class SMD
    {
        public enum Pocasi { dest, slunecno, kroupy, zatazeno, bourka }
    }

    class RC
    {

    }

    class AV
    {
        public delegate void Vozidlo(double rychlost, double delka_trasy, Teren t, bool svetla, List<Trasa> Tr);
    }


}
