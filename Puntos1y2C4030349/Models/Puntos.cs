using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Puntos1y2C4030349.Models
{
    public class Puntos
    {
        public double A { get; set; }
        public double B { get; set; }


        public static double CalcularDistancia(Puntos p1, Puntos p2)
        {
            return Math.Sqrt(Math.Pow(p2.A - p1.A, 2) + Math.Pow(p2.B - p1.B, 2));
        }


    }
}
