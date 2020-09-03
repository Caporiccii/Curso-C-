using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace Curso.ExerciciosLogica
{
   public class SaidaDeDados
    {
        string computador = "Computador";
        string mesa = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double precoComputador = 2100.0;
        double precoMesa = 650.20;
        double medida = 53.234567;
        

        public void EscreveTextoExercicio()
        {
            double medidaArredondada = Math.Round(medida, 3);

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{ computador}, cujo preço é R$ {precoComputador}");
            Console.WriteLine($"{ mesa}, cujo preço é R$ {precoMesa}");
            Console.WriteLine();
            Console.WriteLine($"Registro:{idade} anos de idade, código: {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida);
            Console.WriteLine("Arredondado 3 casas decimais: " + medidaArredondada);
            // Outro exemplo: Console.WriteLine($"Arredondado 3 casas decimais:{medidaArredondada:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medidaArredondada.ToString(CultureInfo.InvariantCulture)}");

        }

    }
}
