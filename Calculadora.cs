using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFracao
{
    internal static class Calculadora
    {
       

        public static Fracao Somar(Fracao f1, Fracao f2)
        {

            if (f1.Denominador == f2.Denominador)
            {
                Fracao resultado = new Fracao(f1.Numerador + f2.Numerador, f1.Denominador);

                return resultado;     
            }
            else
            {
                Console.WriteLine("os denominadores precisam ser iguais para poder realizar a soma.");
                return new Fracao (0,0);
            }
        }
        public static Fracao Subtrair(Fracao f1,Fracao f2)
        {
                if (f1.Denominador == f2.Denominador)
                {
                    Fracao resultado = new Fracao(f1.Numerador - f2.Numerador, f1.Denominador);
                    return resultado;
                }
                else
                {
                    Console.WriteLine("os denominadores precisam ser iguais para poder realizar a subtração.");
                    return new Fracao(0,0);
                } 
        }
        public static Fracao Divisao(Fracao f1, Fracao f2)
        {
            Fracao resultado = new Fracao(f1.Numerador * f2.Denominador, f1.Denominador * f2.Numerador);
            return resultado;

        }
        public static Fracao Multiplicacao(Fracao f1, Fracao f2)
        {
            Fracao resultado = new Fracao (f1.Numerador * f2.Numerador, f1.Denominador * f2.Denominador);
            return resultado;
        }
    }  
}

