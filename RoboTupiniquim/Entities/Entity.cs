using System.ComponentModel;

namespace RoboTupiniquim.Entities;

public class Entity
{
    protected static int PositionX {  get; set; }
    protected static int PositionY { get; set; }
    protected static char Direction { get; set; }

    public static void TurnLeft()
    {
        if (Direction == 'N')
            Direction = 'O';
        else if (Direction == 'O')
            Direction = 'S';
        else if (Direction == 'S')
            Direction = 'L';
        else if (Direction == 'L')
            Direction = 'N';

    }
    public static void TurnRight()
    {
        if (Direction == 'N')
            Direction = 'L';
        else if (Direction == 'L')
            Direction = 'S';
        else if (Direction == 'S')
            Direction = 'O';
        else if (Direction == 'O')
            Direction = 'N';
    }
    public static void MoveOn()
    {
        if (Direction == 'N')
            PositionY += 1;
        if (Direction == 'S')
            PositionY -= 1;
        if (Direction == 'L')
            PositionX += 1;
        if (Direction == 'O')
            PositionX -= 1;
    }
}
