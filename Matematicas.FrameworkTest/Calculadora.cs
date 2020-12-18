using System;

namespace Matematicas.FrameworkTest
{
    internal class Calculadora
    {
        public Calculadora()
        {
        }

        internal int AumentarEntero(int numeroEntero1, int numeroEntero2)
        {
            int sum = numeroEntero1;
            for (int i = 0; i < numeroEntero2; i++)
            {
                sum += 1;
            }
            return sum;

        }

        internal double RaizCuadrada(double numero1)
        {
            if (numero1 < 0)
                throw new ArgumentException("No recibe numeros negativos");

            return Math.Sqrt(numero1);
        }

        internal bool Validar(int edad)
        {
            if (edad < 18)
            {
                return false;
            }
            return true;
        }

        internal object AlgoritmoHoffmann(string letra, int vecesRepite)
        {
            if (letra );
        }
    }
}