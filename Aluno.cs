namespace ESWAEECalculadoraDeMedias.Library.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public bool EstaAprovado(double mediaMinima = 7.0)
        {
            return CalcularMedia() >= mediaMinima;
        }
    }
}