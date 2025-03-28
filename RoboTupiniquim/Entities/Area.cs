namespace RoboTupiniquim.Entities;

public class Area
{
    public static int MaxX { get; set; }
    public static int MaxY { get; set; }

    public static bool RobotIsInside(int x, int y)
    {
        return x >= 0 && x <= MaxX && y >= 0 && y <= MaxY;
    }
}
