using calculatorAdvanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAdvanced
{
    public class operacoes
    {
        public static int number                 { get; set; } 
        public static int number2                { get; set; }
        public static int operacao               { get; set; }
        public static double resultadoDaOperacao { get; set; }


        //Arrow Function
        public static double soma(int valor1, int valor2) => valor1 + valor2;   

        public static double subtracao(int valor1, int valor2) //=> valor1 - valor2;
        {
            if (valor1 < 0)
                throw new ArgumentOutOfRangeException(nameof(valor1), $"O valor {valor1} não pode ser subtraído por {valor2}!");
            return valor1 - valor2;
        }
        public static double multiplicacao(int valor1, int valor2) => valor1 * valor2;
        
        public static double divisao(int valor1, int valor2)// => valor1 / valor2;
        {
            if (valor2 == 0)
                throw new DivideByZeroException($"O {valor1} não pode ser divido por {valor2}!");
            return valor1 / valor2;
        }
        
        public static double operacaoFunction(double operation, int valor1, int valor2, double resultado)
        {

            switch (operation)
            {
                case 1:
                    resultado = soma(valor1, valor2);
                    break;

                case 2:
                    resultado = subtracao(valor1, valor2);
                    break;

                case 3:
                    resultado = multiplicacao(valor1, valor2);
                    break;

                case 4:
                    resultado = divisao(valor1, valor2);
                    break;

                default:
                    break;
            }

            return resultado;
        }
        
    }
}
