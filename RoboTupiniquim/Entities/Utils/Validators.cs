namespace RoboTupiniquim.Entities.Utils;

public class Validators
{
    public static int IntVerify(string prompt, int minValue = 0, int maxValue = int.MaxValue)
    {
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine()!;
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"'{input}' não é um número...");
                continue;
            }
            input = input.Trim();
            if (input.Contains(' ') || input.Contains('.') || input.Contains(','))
            {
                Console.WriteLine("O valor não pode conter espaço ' ', ponto (.), ou vírgula (,)!");
                continue;
            }
            if (!int.TryParse(input, out int value))
            {
                Console.WriteLine("O valor digitado não é um número válido.");
                continue;
            }
            if (value <= minValue || value > maxValue)
            {
                Console.WriteLine($"O valor deve estar entre 1 e {maxValue}.");
                continue;
            }
            return value;
        } while (true);
    }
    public static string StringVerify(string lenghtError, int minLenght)
    {
        do
        {
            string input = Console.ReadLine()!;
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"'{input}' não me parece correto...", ConsoleColor.Red);
                continue;
            }
            if (!input.All(char.IsLetter))
            {
                Console.WriteLine($"Tem algo de errado com essa palavra... ({input})", ConsoleColor.Red);
                continue;
            }
            if (input.Length < minLenght)
            {
                Console.WriteLine(lenghtError, ConsoleColor.Red);
                continue;
            }
            return input;
        } while (true);
    }
}
