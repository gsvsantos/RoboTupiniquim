using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim.Entities;

public class Area
{
    public static int MaxX { get; set; }
    public static int MaxY { get; set; }

    public static void AreaCreate()
    {
        string[] values = Validators.AreaLimitVerify();
        MaxX = Convert.ToInt32(values[0]);
        MaxY = Convert.ToInt32(values[1]);
    }
    public static bool RobotIsInside(int x, int y)
    {
        return x >= 0 && x <= MaxX && y >= 0 && y <= MaxY;
    }
}
