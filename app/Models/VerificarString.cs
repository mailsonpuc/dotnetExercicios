using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;


namespace app.Models
{
    public class VerificarString
    {
        public VerificarString(string _nome)
        {
            Nome = _nome;
            
        }

        public string Nome { get; set; }
 

        public void Verificar()
        {
            var tipo = Nome.GetType(); 
            bool Emaiuscula = Nome.All(char.IsUpper);
            bool Enumero = Nome.All(char.IsDigit);
            bool Eminuscula = Nome.All(char.IsLower);
            bool Sotemespacos = Nome.All(char.IsWhiteSpace);


            Console.WriteLine($"{Nome} tipo primitivo e {tipo}\nEsta em maiuscula? {Emaiuscula}\nÈ digito? {Enumero}\nÈ minuscula? {Eminuscula}\nSo tem espaços? {Sotemespacos}");


        }

    }
}