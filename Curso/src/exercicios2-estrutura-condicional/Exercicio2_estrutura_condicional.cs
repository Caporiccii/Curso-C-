using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso.src.exercicios2_estrutura_condicional
{
    public class Exercicio2_estrutura_condicional
    {
        public void Multiplos() {
            var numero1 = 0.0;
            var numero2 = 0.0;

            Console.WriteLine("Saiba se os numeros são multiplos");
            string[] vetor = Console.ReadLine().Split(' ');
            numero1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            numero2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);

         

            if (numero1% numero2 == 0 || numero2%numero1 ==0 )
                Console.WriteLine("São Multiplos");
            else
                Console.WriteLine("Não são Multiplos");


        }
    }
}
