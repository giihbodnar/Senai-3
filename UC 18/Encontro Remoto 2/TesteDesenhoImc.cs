using CalculoIMC;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
         float Altura, Peso, imc;
    
            Console.Write("Informe o peso:");
            Peso =float.Parse(Console.ReadLine());


            Console.Write("Informe a altura:");
            Altura = float.Parse(Console.ReadLine());
      
            imc=(Peso /(Altura*Altura ));
            
              if(imc<18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
             else if ((imc >= 18.5) && (imc <= 24.9))
            {
                Console.WriteLine("Peso normal");
            }
              if ((imc >= 25) && (imc <= 29.9))
            {
                Console.WriteLine("Sobrepeso");
            }
              else if ((imc >= 30) && (imc <= 34.9))
            {
                Console.WriteLine("Grau de Obesidade I");
            }
              if ((imc >= 35)  &&  (imc <= 39.9))
            {
                Console.WriteLine("Grau de Obesidade II");
            }
             else if (imc >40)
            {
                Console.WriteLine("Obesidade Grau III");
            }
            Console.ReadKey();
        }
    }
}