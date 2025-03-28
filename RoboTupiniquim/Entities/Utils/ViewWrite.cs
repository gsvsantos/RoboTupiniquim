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
    public static void PrintArea()
    {
        Console.WriteLine($"Área definida com limites de: ({Area.MaxX}, {Area.MaxY})");
    }
}
