namespace RoboTupiniquim.Entities.Utils;

public class ViewWrite
{
    public static void Header()
    {
        Console.Clear();
        ViewColors.PaintWriteLine("/=-=-=-=-=-=-=-=-=-=-=-=\\");
        ViewColors.PaintWriteLine("     Robô Tupiniquim", ConsoleColor.Cyan);
        ViewColors.PaintWriteLine("\\=-=-=-=-=-=-=-=-=-=-=-=/\n");
    }
    public static void PrintArea()
    {
        ViewColors.PaintWriteLine($"Área definida com limites de: {Area.MaxX} {Area.MaxY}");
    }
    public static void InitialPosition(int positionX, int positionY, char direction)
    {
        ViewColors.PaintWriteLine($"\nRobô saindo da posição: {positionX} {positionY} {direction}\n", ConsoleColor.Green);
    }
    public static void LookToDirection(char oldDirection, char newDirection)
    {
        ViewColors.PaintWriteLine($"Virou a direção de {oldDirection} para {newDirection}.", ConsoleColor.Magenta);
    }
    public static void MovingOnPositions(int positionX, int positionY, char direction)
    {
        ViewColors.PaintWriteLine($"Moveu para frente: {positionX} {positionY} {direction}", ConsoleColor.Blue);
    }
    public static void RobotOutAreaActualPosition(int id, int positionX, int positionY, char direction)
    {
        ViewColors.PaintWriteLine($"Posição atual do Robô #{id} fora da área: {positionX} {positionY} {direction}\n", ConsoleColor.DarkRed);
    }
    public static void LastPosition(int id, int positionX, int positionY, char direction)
    {
        ViewColors.PaintWriteLine($"Posição final do Robô #{id}: {positionX} {positionY} {direction}\n");
    }
}