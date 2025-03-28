using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim.Entities;

internal class Robot : Entity
{
    public static int id = 0;

    public Robot()
    {
        Id = ++id;
    }
    public void TurnLeft(bool watchRobotSteps)
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

        if (watchRobotSteps == true)
            ViewWrite.LookToDirection(oldDirection, Direction);
    }
    public void TurnRight(bool watchRobotSteps)
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

        if (watchRobotSteps == true)
            ViewWrite.LookToDirection(oldDirection, Direction);
    }
    public void MoveOn(bool watchRobotSteps)
    {
        if (Direction == 'N')
            PositionY += 1;
        else if (Direction == 'S')
            PositionY -= 1;
        else if (Direction == 'L')
            PositionX += 1;
        else if (Direction == 'O')
            PositionX -= 1;

        if (watchRobotSteps == true)
        {
            ViewWrite.MovingOnPositions(PositionX, PositionY, Direction);
        }
    }
    public void GetData()
    {
        string[] data = Validators.RobotDataVerify(Id);
        PositionX = Convert.ToInt32(data[0]);
        PositionY = Convert.ToInt32(data[1]);
        Direction = Convert.ToChar(data[2]);
    }
    public void GetCommands()
    {
        do
        {
            char[] commands = Validators.RobotCommandsVerify();
            ViewWrite.InitialPosition(PositionX, PositionY, Direction);
            bool watchRobotSteps = ViewUtils.YesOrNo();
            Console.WriteLine();

            foreach (char c in commands)
            {
                if (c == 'D')
                    TurnRight(watchRobotSteps);
                else if (c == 'E')
                    TurnLeft(watchRobotSteps);
                else if (c == 'M')
                    MoveOn(watchRobotSteps);
            }

            if (!Area.RobotIsInside(PositionX, PositionY))
            {
                ViewWriteErrors.InvalidLastPosition();
                ViewWrite.RobotOutAreaActualPosition(Id, PositionX, PositionY, Direction);
                continue;
            }
            else
                break;
        } while (true);
    }
}
