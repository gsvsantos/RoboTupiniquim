using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim.Entities;

internal class Area
{
    public static int MaxX, MaxY;
    public static void AreaCreate()
    {
        string[] values = Validators.AreaLimitVerify();
        MaxX = Convert.ToInt32(values[0]);
        MaxY = Convert.ToInt32(values[1]);
    }
    public static bool RobotIsInside(int positionX, int positionY)
    {
        return positionX >= 0 && positionX <= MaxX && positionY >= 0 && positionY <= MaxY;
    }

}
