using System;


namespace ExampleFeatureCsharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region New feature C#8.0 - Ranges

            var cursos = new string[] { ".NET CORE", "C#", "ENTITY FRAMEWORK", "NODE JS", "ANGULAR" };

            Console.WriteLine("-------------------------EXEMPLO  RANGES C# 8.0--------------------------");

            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (var item in cursos)
            {
                Console.WriteLine($"Trazendo todos os valores do array: {item}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (var item in cursos[0..3])
            {
                Console.WriteLine($"Trazendo 3 valores selecionados do array: {item}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (var item in cursos[0..^4])
            {
                Console.WriteLine($"Trazendo somente a posição zero do array:: {item}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (var item in cursos[1..^3])
            {
                Console.WriteLine($"Trazendo somente a posição um do array:: {item}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (var item in cursos[2..^2])
            {
                Console.WriteLine($"Trazendo somente a posição dois do array:: {item}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (var item in cursos[3..^1])
            {
                Console.WriteLine($"Trazendo somente a posição três do array:: {item}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------------------");
            foreach (var item in cursos[4..^0])
            {
                Console.WriteLine($"Trazendo somente a posição quatro do array:: {item}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            #endregion

            #region New feature C#8.0 - Switch Expression
            Console.WriteLine("-------------------------Switch Expression--------------------------");
            Console.WriteLine("Soma 4 + 2 : " +
                Calculo.Calcular(TipoCalculo.Soma, 4, 2));
            Console.WriteLine("Subtrair  4 - 2: " +
                Calculo.Calcular(TipoCalculo.Subtrair, 4, 2));
            Console.WriteLine("Multiplicar 4 * 2: " +
                 Calculo.Calcular(TipoCalculo.Multiplicar, 4, 2));
            Console.WriteLine("Dividir 4 / 2: " +
                 Calculo.Calcular(TipoCalculo.Dividir, 4, 2));
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine();

            #endregion

            #region New feature C#8.0 - Switch Tuple Patterns

            Console.WriteLine("-------------------------Switch Tuple Patterns--------------------------");
            Console.WriteLine("Soma 4 + 2 : " +
                Calculo.RealizaCalculo(TipoCalculo.Soma, PermiteCalcular.Sim, 4, 2));
            Console.WriteLine("Subtrair  4 - 2: " +
                Calculo.RealizaCalculo(TipoCalculo.Soma, PermiteCalcular.Sim, 4, 2));
            Console.WriteLine("Multiplicar 4 * 2: " +
                 Calculo.RealizaCalculo(TipoCalculo.Soma, PermiteCalcular.Sim, 4, 2));
            Console.WriteLine("Dividir 4 / 2: " +
                 Calculo.RealizaCalculo(TipoCalculo.Soma, PermiteCalcular.Sim, 4, 2));
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine();

            #endregion
        }
    }
}
