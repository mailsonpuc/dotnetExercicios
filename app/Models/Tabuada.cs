namespace app.Models
{
    public class Tabuada
    {
        public Tabuada(int _numero)
        {
            Numero = _numero;
        }


        public int Numero { get; set; }

        public void FazerTabuada()
        {
            Console.WriteLine($"Mostrando a tabuada do numero {Numero}");
        

            for(int x =0; x <=10; x++){
                    Console.WriteLine($"{Numero} X {x} = {x * Numero}");
            }



        }
    }
}