using Encontro_Remoto_4.Interfaces;

namespace Encontro_Remoto_4.Classes

{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }
        
        public override float CalcularImposto(float rendimento)
        {
            if ( rendimento <= 1500 )
            {
                return 0;

            } else if ( rendimento > 1500 && rendimento <= 3500 ) // && => interligar duas condições e retornar true ou false
            {
                float result = ( rendimento / 100 ) * 2;
                return result;

            } else if ( rendimento > 3500 && rendimento <= 6000 )
            {
                float result = ( rendimento / 100 ) * 3.5f; // f => float
                return result;

            } else 
            {
                float result = ( rendimento / 100 ) * 5;
                return result;
            }
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;
            Console.WriteLine(anos);

            if (anos >= 18)
            {
                return true;
            }

            return false;
        }

        public bool ValidarDataNasc(string dataNasc)
        {
            if (DateTime.TryParse(dataNasc, out DateTime dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - dataConvertida).TotalDays / 365;
                Console.WriteLine(anos);

                if (anos >= 18)
                {
                    return true;
                }

            }
            return false;
        }
    }
}