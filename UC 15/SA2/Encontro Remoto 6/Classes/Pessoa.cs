using Encontro_Remoto_6.Interface;

namespace Encontro_Remoto_6.Classes

{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }

        public float rendimento { get; set; }

        public Endereco? endereco { get; set; }

        public abstract float CalcularImposto(float rendimento);
    }
}