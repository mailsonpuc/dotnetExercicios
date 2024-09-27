
using app.Models;

namespace app.test.SucessorEantecessorTest
{
    public class SucessorEantecessorTest
    {
        private SucessorEantecessor _SucessorEantecessor;

        //construtor
        public SucessorEantecessorTest()
        {
            _SucessorEantecessor = new SucessorEantecessor();
        }


       //test Antecessor
       [Fact]
       public void DeverFazerOAntecessoDe10eRetorna9()
       {
          //arrange
          int numero = 10;
          //act
          int resultado = _SucessorEantecessor.AnteCessor(numero);
          //assert
          Assert.Equal(9, resultado);
       }


       //TestSucessor
       [Fact]
       public void DeverFazerOsucesssorDe10eRetorna11()
       {
          //arrange
          int numero = 10;
          //act
          int resultado = _SucessorEantecessor.Sucessor(numero);
          //assert
          Assert.Equal(11, resultado);
       }


    }
}