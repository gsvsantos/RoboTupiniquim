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
            if (input.Contains('.') || input.Contains(','))
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
    public static string LetterVerify(string prompt, string lenghtError, int minLenght = 1, int maxLenght = int.MaxValue)
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
                ViewWriteErrors.CommandsNeedsToBeLetters();
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
    public static char[] RobotCommandsVerify() //verificar se é D E M
    {
        do
        {
            char[] commands = ViewUtils.GetCommandList();
            bool wrongCommand = false;
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] != 'D' || commands[i] != 'E' || commands[i] != 'M')
                {
                    ViewWriteErrors.CommandsNeedsToBeLetters();
                    wrongCommand = true;
                    break;
                }
            }
            if (wrongCommand == true)
                continue;
            else
                return commands;
        }while (true);
    }
    public static string[] RobotDataVerify() //verificar se inicia com xInt, yInt, directionChar
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
        } while (true);
    }
}
