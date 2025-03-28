using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim.Entities;

internal class Robot02
{
    public static int PositionX { get; set; }
    public static int PositionY { get; set; }
    public static char Direction { get; set; }
    public static int Id = 2;

    public static void GetData()
    {
        string[] data = Validators.RobotDataVerify(Id);
        PositionX = Convert.ToInt32(data[0]);
        PositionY = Convert.ToInt32(data[1]);
        Direction = Convert.ToChar(data[2]);
    }
    public static void GetCommands()
    {
        do
        {
            char[] commands = Validators.RobotCommandsVerify();
            RunCommands(commands);
            if (!Area.RobotIsInside(PositionX, PositionY))
            {
                ViewWriteErrors.InvalidLastPosition();
                ViewWrite.RobotOutAreaActualPosition(Id, PositionX, PositionY, Direction);
                continue;
            }
            return;
        } while (true);
    }
    private static void RunCommands(char[] commands)
    {
        ViewWrite.InitialPosition(PositionX, PositionY, Direction);
        bool watchRobotSteps = ViewUtils.YesOrNo();
        Console.WriteLine();

        foreach (char command in commands)
        {
            if (command == 'D')
                TurnRight(watchRobotSteps);
            else if (command == 'E')
                TurnLeft(watchRobotSteps);
            else if (command == 'M')
                MoveOn(watchRobotSteps);
        }
    }
    public static void TurnLeft(bool watchRobotSteps)
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
    public static void TurnRight(bool watchRobotSteps)
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
    public static void MoveOn(bool watchRobotSteps)
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
}
