using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFracao
{
    internal class Fracao
    {
        public int Denominador { get; set; }
        public int Numerador { get; set; }
        public Fracao(int numerador, int denominador)
        { 
            if (denominador == 0)
            {
                throw new ArgumentException("Muito burro");
            }
            Denominador = denominador;
            Numerador = numerador;
        }
        public override string ToString()
        {
            return $"{this.Numerador}/{this.Denominador}";
        }
    }
}
