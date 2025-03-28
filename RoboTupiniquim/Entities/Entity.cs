using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim.Entities;

public class Entity
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public char Direction { get; set; }

    public virtual void TurnLeft()
    {
        char oldDirection = Direction;

        if (Direction == 'N')
            Direction = 'O';
        else if (Direction == 'O')
            Direction = 'S';
        else if (Direction == 'S')
            Direction = 'L';
        else if (Direction == 'L')
            Direction = 'N';

        ViewWrite.LookToDirection(oldDirection, Direction);
    }
    public virtual void TurnRight()
    {
        char oldDirection = Direction;

        if (Direction == 'N')
            Direction = 'L';
        else if (Direction == 'L')
            Direction = 'S';
        else if (Direction == 'S')
            Direction = 'O';
        else if (Direction == 'O')
            Direction = 'N';

        ViewWrite.LookToDirection(oldDirection, Direction);
    }
    public virtual void MoveOn()
    {
        if (Direction == 'N')
            PositionY += 1;
        else if (Direction == 'S')
            PositionY -= 1;
        else if (Direction == 'L')
            PositionX += 1;
        else if (Direction == 'O')
            PositionX -= 1;

        if (Area.RobotIsInside(PositionX, PositionX))
        {
            ViewWrite.MovingOnPositions(PositionX, PositionY, Direction);
        }
        else
        {
            ViewWriteErrors.InvalidLastPosition();
        }
    }
    public virtual void GetData()
    {
        string[] data = Validators.RobotDataVerify();
        PositionX = Convert.ToInt32(data[0]);
        PositionY = Convert.ToInt32(data[1]);
        Direction = Convert.ToChar(data[2]);
    }
    public virtual void GetCommands()
    {

        char[] commands = Validators.RobotCommandsVerify();
        ViewWrite.InitialPosition(PositionX, PositionY, Direction);
        foreach (char c in commands)
        {
            if (c == 'D')
                TurnRight();
            else if (c == 'E')
                TurnLeft();
            else if (c == 'M')
                MoveOn();
        }
    }
}
