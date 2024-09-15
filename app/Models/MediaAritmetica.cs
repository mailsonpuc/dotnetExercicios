using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class MediaAritmetica
    {
       

        public MediaAritmetica(double _n1, double _n2)
        {
            N1 = _n1; 
            N2 = _n2; 
        }


        public double N1 { get; set; }
        public double N2 { get; set; }


        public void Verifiar()
        {
          
            var media = (N1 + N2) / 2;
            
            Console.WriteLine($"A media entre {N1} e {N2} e ingual a {media}");

        }
    }
}