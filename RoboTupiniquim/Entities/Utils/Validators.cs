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
                ViewWriteErrors.InputIsNullOrEmpty(input);
                continue;
            }
            input = input.Trim();
            if (input.Contains(' ') || input.Contains('.') || input.Contains(','))
            {
                ViewWriteErrors.IntCannotHaveSpaceDotComma();
                continue;
            }
            if (!int.TryParse(input, out int value))
            {
                ViewWriteErrors.InvalidInt();
                continue;
            }
            if (value <= minValue || value > maxValue)
            {
                ViewWriteErrors.IntNeedBetweenMinAndMax(maxValue);
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
                ViewWriteErrors.InputIsNullOrEmpty(input);
                continue;
            }
            if (!input.All(char.IsLetter))
            {
                ViewWriteErrors.InvalidString(input);
                continue;
            }
            if (input.Length < minLenght || input.Length > maxLenght)
            {
                ViewWriteErrors.StringNeedBetweenMinAndMax(lenghtError);
                continue;
            }
            return input;
        } while (true);
    }
}
