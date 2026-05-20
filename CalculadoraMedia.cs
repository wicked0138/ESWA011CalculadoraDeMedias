namespace ESWAEECalculadoraDeMedias.Library
{
    // Princípios SOLID: SRP - Single Responsibility Principle
    // Esta classe tem apenas a responsabilidade de calcular médias
    public class CalculadoraMedia
    {
        public double CalcularMedia(params double[] notas)
        {
            if (notas == null || notas.Length == 0)
                throw new ArgumentException("Pelo menos uma nota é necessária");

            double soma = 0;
            foreach (var nota in notas)
            {
                if (nota < 0 || nota > 10)
                    throw new ArgumentException($"Nota {nota} inválida. As notas devem estar entre 0 e 10");
                soma += nota;
            }
            return soma / notas.Length;
        }

        // Princípios SOLID: OCP - Open/Closed Principle
        // Método extensível por estratégia de aprovação
        public bool VerificarAprovacao(double media, double mediaMinima = 7.0)
        {
            return media >= mediaMinima;
        }
    }
}