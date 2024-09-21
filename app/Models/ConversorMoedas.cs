namespace app.Models
{
    public class ConversorMoedas
    {
        public ConversorMoedas(double _real)
        {
            Real = _real;
        }

        public double Real{ get; set; }


        public void ConverteParaUsdt(){
            double usdt = Real / 5.509;

            Console.WriteLine($"Com R$: {Real}, Voce pode comprar U$: {usdt}");
        }
        
    }
}