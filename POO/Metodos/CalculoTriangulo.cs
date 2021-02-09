using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace POO.Metodos
{
    public class CalculoTriangulo
    {
        private double _formulaPerimetroX;
        private double _formulaPerimetroY;
        private double _areaX;
        private double _areaY;
        private Triangulo _trianguloX;
        private Triangulo _trianguloY;



        public double CalculaAreaPrimeiroTriangulo()
        {
            _trianguloX = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo X:");

            _trianguloX.BaseTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            _trianguloX.LadoEsquerdoTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            _trianguloX.LadoDireitoTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CalculoPerimetro();

            double area = CalculaArea();

            return area;
        }

        public double CalculaAreaSegundoTriangulo()
        {
            _trianguloY = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo Y:");

            _trianguloY.BaseTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            _trianguloY.LadoEsquerdoTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            _trianguloY.LadoDireitoTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CalculoPerimetroY();

            double area = CalculaAreaY();

            return area;
        }
        public double CalculoPerimetro() => _formulaPerimetroX =
         (_trianguloX.BaseTriangulo + _trianguloX.LadoEsquerdoTriangulo + _trianguloX.LadoDireitoTriangulo) / 2.0;

        public double CalculaArea() => _areaX = Math.Sqrt(_formulaPerimetroX * (_formulaPerimetroX - _trianguloX.BaseTriangulo)
                * (_formulaPerimetroX - _trianguloX.LadoEsquerdoTriangulo) * (_formulaPerimetroX - _trianguloX.LadoDireitoTriangulo));

        public double CalculoPerimetroY() => _formulaPerimetroY =
       (_trianguloY.BaseTriangulo + _trianguloY.LadoEsquerdoTriangulo + _trianguloY.LadoDireitoTriangulo) / 2.0;

        public double CalculaAreaY() => _areaY = Math.Sqrt(_formulaPerimetroY * (_formulaPerimetroY - _trianguloY.BaseTriangulo)
                * (_formulaPerimetroY - _trianguloY.LadoEsquerdoTriangulo) * (_formulaPerimetroY - _trianguloY.LadoDireitoTriangulo));


        public void PrintTrianguloMaior()
        {
            var trianguloX = CalculaAreaPrimeiroTriangulo();
            var trianguloY = CalculaAreaSegundoTriangulo();

            Console.WriteLine("Área de X = " + trianguloX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + trianguloY.ToString("F4", CultureInfo.InvariantCulture));
            if (trianguloX > trianguloY)
                Console.WriteLine("Maior área: X");
            else if (trianguloX < trianguloY)
                Console.WriteLine("Maior área: Y");
            else
                Console.WriteLine("Ambos triangulos tem mesma área.");
        }

        public void Handle()
        {
            PrintTrianguloMaior();
        }
    }
}
