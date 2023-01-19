namespace Encontro_Remoto_6.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto){
            
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Magenta;

            Console.Write($"{texto}");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"=");
                Thread.Sleep(200);    
            }
            Console.ResetColor(); 
            Console.Clear();
        }
    }
}