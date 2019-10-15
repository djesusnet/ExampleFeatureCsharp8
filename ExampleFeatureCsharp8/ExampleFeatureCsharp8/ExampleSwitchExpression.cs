using System;

namespace ExampleFeatureCsharp8
{
    public enum TipoCalculo
    {
        Soma,
        Subtrair,
        Multiplicar,
        Dividir
    }
    public enum PermiteCalcular
    {
        Sim,
        Nao
    }


    public static class Calculo
    {
        #region New feature C#8.0 - Switch Expression

        public static double Calcular(
            TipoCalculo tipoCalculo, double valorEntrada1, double valorEntrada2) =>
        tipoCalculo switch
        {
            TipoCalculo.Soma => valorEntrada1 + valorEntrada2,
            TipoCalculo.Subtrair => valorEntrada1 - valorEntrada2,
            TipoCalculo.Multiplicar => valorEntrada1 * valorEntrada2,
            TipoCalculo.Dividir => valorEntrada1 / valorEntrada2,
            _ => throw new ArgumentException("Tipo de Cálculo inválido!")
        };
        #endregion

        #region New feature C#8.0 - Switch Tuple Patterns
        public static double RealizaCalculo(
            TipoCalculo tipoCalculo, PermiteCalcular permiteCalcular, double valorEntrada1, double valorEntrada2) =>
        (tipoCalculo, permiteCalcular) switch
        {
            (TipoCalculo.Soma, PermiteCalcular.Sim) => valorEntrada1 + valorEntrada2,
            (TipoCalculo.Subtrair, PermiteCalcular.Sim) => valorEntrada1 - valorEntrada2,
            (TipoCalculo.Multiplicar, PermiteCalcular.Sim) => valorEntrada1 * valorEntrada2,
            (TipoCalculo.Dividir, PermiteCalcular.Sim) => valorEntrada1 / valorEntrada2,
            _ => throw new ArgumentException("Não foi permitido realizar o Cálculo!")
        };
        #endregion
    }


}
