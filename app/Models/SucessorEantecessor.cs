using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class SucessorEantecessor
    {
        public SucessorEantecessor(int _numero)
        {
            Numero = _numero;

        }


        public int Numero { get; set; }

        public void Verificar(){
            var antecessor = Numero - 1;
            var sucessor = Numero + 1;

            Console.WriteLine($"Analizando o número {Numero} seu antecessor e {antecessor} e o sucessor é {sucessor}");
        }
    }
}