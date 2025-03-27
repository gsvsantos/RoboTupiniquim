namespace RoboTupiniquim.Entities.Utils;

public class Validators
{
    public static int IntVerify(string prompt, int minValue = 0, int maxValue = int.MaxValue)
    {
        do
        {
           ViewColors.PaintWrite(prompt);
            string input = Console.ReadLine()!;
            if (string.IsNullOrEmpty(input))
            {
                ViewColors.PaintWriteLine($"'{input}' não é um número...", ConsoleColor.Red);
                continue;
            }
            input = input.Trim();
            if (input.Contains(' ') || input.Contains('.') || input.Contains(','))
            {
                ViewColors.PaintWriteLine("O valor não pode conter espaço ' ', ponto (.), ou vírgula (,)!", ConsoleColor.Red);
                continue;
            }
            if (!int.TryParse(input, out int value))
            {
                ViewColors.PaintWriteLine("O valor digitado não é um número válido.", ConsoleColor.Red);
                continue;
            }
            if (value <= minValue || value > maxValue)
            {
                ViewColors.PaintWriteLine($"O valor deve estar entre 1 e {maxValue}.", ConsoleColor.Red);
                continue;
            }
            return value;
        } while (true);
    }
    public static string StringVerify(string prompt, string lenghtError, int minLenght, int maxLenght = int.MaxValue)
    {
        do
        {
            ViewColors.PaintWrite(prompt);
            string input = Console.ReadLine()!;
            if (string.IsNullOrEmpty(input))
            {
                ViewColors.PaintWriteLine($"'{input}' não me parece correto...", ConsoleColor.Red);
                continue;
            }
            if (!input.All(char.IsLetter))
            {
                ViewColors.PaintWriteLine($"Tem algo de errado com essa palavra... ({input})", ConsoleColor.Red);
                continue;
            }
            if (input.Length < minLenght || input.Length > maxLenght)
            {
                ViewColors.PaintWriteLine(lenghtError, ConsoleColor.Red);
                continue;
            }
            return input;
        } while (true);
    }
}
