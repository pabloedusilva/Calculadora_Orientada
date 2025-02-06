namespace Calculadora
{
    public class Operacoes
    {
        public static void Adicao(decimal valor1, decimal valor2)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"A soma dos números {valor1} + {valor2} = {valor1 + valor2}");
            Console.ResetColor();
        }

        public static void Subtraçao(decimal valor1, decimal valor2)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"A subtração dos números {valor1} + {valor2} = {valor1 - valor2}");
            Console.ResetColor();
        }

        public static void Multiplicacao(decimal valor1, decimal valor2)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(
                $"A multiplicação dos números {valor1} * {valor2} = {valor1 * valor2}"
            );
            Console.ResetColor();
        }

        public static void Divisao(decimal valor1, decimal valor2)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"A divisão dos números {valor1} / {valor2} = {valor1 / valor2}");
            Console.ResetColor();
        }
    }
}
