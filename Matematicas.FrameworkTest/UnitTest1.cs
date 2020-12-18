using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Matematicas.FrameworkTest
{
    [TestClass]
    public class UnitTest1
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [TestMethod]

        [DataRow(1, 2, 3)]
        // [DataRow(2,-3,-1)]
        //[DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]
        // [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        // @"|C:\Users\user\Desktop\procesos de desarrollo\Matematicas.FrameworkTest\Matematicas.FrameworkTest\Data\data.csv|\data\data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void AumentarEntero(int numeroEntero1, int numeroEntero2, int esperado)
        {
            // var numeroEntero1 = Convert.ToInt32(TestContext.DataRow["PrimerNumero"]);
            //var numeroEntero2 = Convert.ToInt32(TestContext.DataRow["SegundoNumero"]);
            //var esperado = Convert.ToInt32(TestContext.DataRow["ResultadoSuma"]);

            var calculadora = new Calculadora();
            int resultado = calculadora.AumentarEntero(numeroEntero1, numeroEntero2);

            Assert.AreEqual(esperado, resultado, "numeroEntero1:<{0}> numeroEntero2:<{1}>",
        new object[] { numeroEntero1, numeroEntero2 });


        }
        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroPositivo()
        {
            var numero1 = 25;
            var esperado = 5;
            var calculadora = new Calculadora();
            var resultado = calculadora.RaizCuadrada(numero1);
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroNegativo()
        {
            var numero1 = -25;

            var calculadora = new Calculadora();

            Assert.ThrowsException<ArgumentException>(() => calculadora.RaizCuadrada(numero1));
        }

        [TestMethod]
        public void ValidarEdadPersona()
        {
            var edad = 19;
            var calculadora = new  Calculadora();

            bool resultado = calculadora.Validar(edad);

            Assert.IsTrue( resultado);



        }

        [TestMethod]
        public void crearHoffman(string letra, int vecesRepite, int hoffmann)
        {

            var letra = 1;
            var resultado = calculadora.AlgoritmoHoffmann(letra, vecesRepite);

            Assert.AreEqual(resultado);


        }
    }
}
