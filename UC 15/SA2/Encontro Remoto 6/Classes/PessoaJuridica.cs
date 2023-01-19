using System.Text.RegularExpressions;
using Encontro_Remoto_6.Interface;

namespace Encontro_Remoto_6.Classes

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
        { // 00.476.645/0001-03
           bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");

           if (retornoCnpjValido) 
           {
                string subStringCnpj14 = cnpj.Substring(8, 4);

                if (subStringCnpj14 == "0001")
                {
                    return true;
                }
                
           }

            string subStringCnpj18 = cnpj.Substring (11, 4);

                if (subStringCnpj18 == "0001")
                {
                    return true;
                }

            return false;
            
        }

    }
}