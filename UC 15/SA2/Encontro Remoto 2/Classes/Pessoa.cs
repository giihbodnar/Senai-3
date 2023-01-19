using Encontro_Remoto_2.Interfaces;

namespace Encontro_Remoto_2.Classes

{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }

        public float rendimento { get; set; }

        public string? endereco { get; set; }
        
        public abstract float CalcularImposto(float rendimento);
    }
}