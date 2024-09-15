using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class DobroTriploRaiz
    {
        public DobroTriploRaiz(int _numero)
        {
            Numero = _numero;
            
        }

        public int Numero { get; set; }

        public void Verifiar(){
            var d = Numero * 2;
            var t = Numero * 3;
            var r = Math.Sqrt(Numero);

            Console.WriteLine($"Numero {Numero}: Doubro {d}: Triplo {t}: Raiz {r}");

        }
    }
}