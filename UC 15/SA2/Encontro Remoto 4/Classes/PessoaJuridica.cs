using Encontro_Remoto_4.Interfaces;

namespace Encontro_Remoto_4.Classes

{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if ( rendimento <= 3000 )
            {   
               return rendimento * 0.03f; // 3% do rendimento
                
            } else if ( rendimento > 3000 && rendimento <= 6000 )
            {
                return rendimento * 0.05f; // 5% do rendimento

            } else if ( rendimento > 6000 && rendimento <= 10000 )
            {
                return rendimento * 0.07f; // 7% do rendimento

            } else 
            {
                return rendimento * 0.09f; // 9% do rendimento
            } 
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}