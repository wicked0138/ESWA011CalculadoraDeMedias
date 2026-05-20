namespace ESWAEECalculadoraDeMedias.Library
{
    // Princípios SOLID: SRP - validação isolada
    public static class ValidacaoNota
    {
        public static bool NotaValida(double nota)
        {
            return nota >= 0 && nota <= 10;
        }

        public static void ValidarNota(double nota)
        {
            if (!NotaValida(nota))
                throw new ArgumentException($"Nota {nota} inválida. Deve estar entre 0 e 10");
        }
    }
}