using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ConversorMedidas
    {
        public ConversorMedidas(double _numero)
        {
            Medida = _numero;
        }


        public double Medida { get; set; }


        public void Verificar(){
            //centimetro
            double cm = Medida * 100;
            //melimetro
            double mm = Medida * 1000;
            //decimetro
            double dcm = Medida * 10;
            //decametro
            double dm = Medida / 10;
            //hectometro
            double em = Medida / 100;
            //quilometro
            double km = Medida / 1000;

            Console.WriteLine(@$"
            A medida de {Medida}m, 
            corresponde a:
            {cm} centimetro,
            {mm} metro,
            {dcm} decimetro,
            {dm} decametro,
            {em} hectometro,
            {km} quilometro

            ");

        }
    }
}