namespace RoboTupiniquim.Entities.Utils;

public class ViewWrite
{
    public static void Header()
    {
        Console.Clear();
        ViewColors.PaintWriteLine("/=-=-=-=-=-=-=-=-=-=-=-=\\");
        ViewColors.PaintWriteLine("     Robô Tupiniquim", ConsoleColor.Cyan);
        ViewColors.PaintWriteLine("\\=-=-=-=-=-=-=-=-=-=-=-=/");
    }
}
