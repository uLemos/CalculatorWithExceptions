using calculatorAdvanced;
using CalculatorAdvanced;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using static System.Console;

namespace CalculatorAdvanced
{
    public class calculatorExceptions : operacoes
    {
        static public void secondMain(String[] args)
        {
            try
            {
               divisao(number, number2);
            }
            catch(DivideByZeroException divideByZeroException)
            {
                WriteLine($"Error: {divideByZeroException.Message}");
            }

            try
            {
                subtracao(number, number2);
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                WriteLine($"Error: {argumentOutOfRangeException.Message}");
            }
        }
    }
}
