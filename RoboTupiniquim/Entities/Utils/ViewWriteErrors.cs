namespace RoboTupiniquim.Entities.Utils;

public class ViewWriteErrors
{
    public static void InputIsNullOrEmpty(string input)
    {
        ViewColors.PaintWriteLine($"'{input}' não está certo...", ConsoleColor.Red);
    }
    public static void IntCannotHaveSpaceDotComma()
    {
        ViewColors.PaintWriteLine("O valor não pode conter ponto (.), ou vírgula (,)!", ConsoleColor.Red);
    }
    public static void InvalidInt()
    {
        ViewColors.PaintWriteLine("O valor digitado não é um número válido.", ConsoleColor.Red);
    }
    public static void IntNeedBetweenMinAndMax(int maxValue)
    {
        ViewColors.PaintWriteLine($"O valor deve estar entre 1 e {maxValue}.", ConsoleColor.Red);
    }
    public static void InvalidString(string input)
    {
        ViewColors.PaintWriteLine($"Tem algo de errado com essa palavra... ({input})", ConsoleColor.Red);
    }
    public static void StringNeedBetweenMinAndMax(string lenghtError)
    {
        ViewColors.PaintWriteLine(lenghtError, ConsoleColor.Red);
    }
    public static void PositionNeedsToBeAIntNumber()
    {
        ViewColors.PaintWriteLine($"As posições precisam ser um número inteiro válido!", ConsoleColor.Red);
    }
    public static void DirectionNeedsToBeALetter()
    {
        ViewColors.PaintWriteLine("Precisa ser uma letra...", ConsoleColor.Red);
    }
    public static void CommandsNeedsToBeLetters()
    {
        ViewColors.PaintWriteLine("Os comandos precisam ser letras... (E, D, M)", ConsoleColor.Red);
    }
}
