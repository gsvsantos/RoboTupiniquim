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
            if (input.Length < minLenght || input.Length > maxLenght)
            {
                ViewWriteErrors.StringNeedBetweenMinAndMax(lenghtError);
                continue;
            }
            return input;
        } while (true);
    }
    public static string[] DataVerify()
    {
        do
        {
            string[] data = ViewUtils.GetRobotInitialData();
            bool IsNotNumber = false;
            for (int i = 0; i <= 1; i++)
            {
                if (!int.TryParse(data[i], out _))
                {
                    ViewWriteErrors.PositionNeedsToBeAIntNumber();
                    IsNotNumber = true;
                    break;
                }
            }
            if (IsNotNumber == true)
                continue;
            if (!char.TryParse(data[2], out _))
            {
                ViewWriteErrors.DirectionNeedsToBeALetter();
                continue;
            }
            return data;
        }while (true);
    }
}
