namespace Encontro_Remoto_7.Classes
{
        static class Utils
    {
        public static void BarraCarregamento(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.Write(texto);

            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }

            Console.ResetColor();
        }
    }
}