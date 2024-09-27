using app.Models;

namespace app.test.DobroTriploRaizTest
{
    public class DobroTripoTes
    {
        private DoubroTriplo _DoubroTriplo;

        //construtor
        public DobroTripoTes()
        {
            _DoubroTriplo =  new DoubroTriplo();
        }

        //test doubro
        [Fact]
        public void DeverFazerOdobrode2Eretornar4()
        {
            //arrange
            int num1 = 2;

            //act
            int resultado = _DoubroTriplo.Doubro(num1);
            //assert
            Assert.Equal(4, resultado);
        }


        //test triplo
        [Fact]
        public void DeverFazerOTriplode2Eretornar6()
        {
            //arrange
            int num1 = 2;
            //act
            int resultado = _DoubroTriplo.Triplo(num1);
            //assert
            Assert.Equal(6, resultado);
        }


        //test raiz
        [Fact]
        public void DeverFazerAraizde2EretornarUmVirgula4()
        {
            //arrange
            int num1 = 2;
            //act
            double resultado = _DoubroTriplo.Raiz(num1);
            //assert
            Assert.Equal(1.4142135623730951, resultado);
        }



    }
}