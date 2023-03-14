using CalculatorAdvanced;
using System;
using System.Runtime.InteropServices;

namespace calculatorAdvanced
{
    public class Program : operacoes 
    {
        static public void Main(String[] args)
        {
            Console.WriteLine("\t\t------- CALCULADORA -------\n\n");
            
            Console.Write("Escreva o primeiro valor: ");
            number = int.Parse(Console.ReadLine().ToString());
            
            Console.Write("Escreva o segundo valor: ");
            number2 = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine("Escolha as operações a baixo:\n\n");
            Console.WriteLine("1 - SOMA\n2 - SUBTRAÇÃO\n3 - MULTPLICAÇÃO\n4 - DIVISÃO\n\n");

            Console.Write("\nEscolha a sua operação: ");
            operacao = int.Parse(Console.ReadLine().ToString().ToString());

            resultadoDaOperacao = 0;

            Console.WriteLine($"O resultado da operação é de: {operacaoFunction(operacao, number, number2, resultadoDaOperacao)}");
        }
    }
}