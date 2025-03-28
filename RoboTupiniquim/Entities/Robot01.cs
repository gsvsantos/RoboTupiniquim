using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim.Entities;

internal class Robot01
{
    public static int PositionX { get; set; }
    public static int PositionY { get; set; }
    public static char Direction { get; set; }
    static char[] directionList = { 'N', 'O', 'S', 'L', };
    static char[] commandList = { 'D', 'E', 'M' };
    public static int Id = 1;

    public static void GetData()
    {
        do
        {
            string[] data = Validators.RobotDataVerify(Id);
            if (Convert.ToInt32(data[0]) > Area.MaxX || Convert.ToInt32(data[1]) > Area.MaxY)
            {
                ViewWriteErrors.RobotIsOutOfAreaRange();
                continue;
            }

            PositionX = Convert.ToInt32(data[0]);
            PositionY = Convert.ToInt32(data[1]);
            Direction = Convert.ToChar(data[2]);

            break;
        } while (true);
    }
    public static void GetCommands()
    {
        do
        {
            char[] commands = Validators.RobotCommandsVerify();
            RunCommands(commands);
            if (!Area.RobotIsInside(PositionX, PositionY))
            {
                ViewWriteErrors.RobotIsOutOfAreaRange();
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
            if (command == commandList[0])
                TurnRight(watchRobotSteps);
            else if (command == commandList[1])
                TurnLeft(watchRobotSteps);
            else if (command == commandList[2])
                MoveOn(watchRobotSteps);
        }
    }
    public static void TurnLeft(bool watchRobotSteps)
    {
        char oldDirection = Direction;

        if (Direction == directionList[0])
            Direction = directionList[1];

        else if (Direction == directionList[1])
            Direction = directionList[2];

        else if (Direction == directionList[2])
            Direction = directionList[3];

        else if (Direction == directionList[3])
            Direction = directionList[0];

        if (watchRobotSteps == true)
            ViewWrite.LookToDirection(oldDirection, Direction);
    }
    public static void TurnRight(bool watchRobotSteps)
    {
        char oldDirection = Direction;

        if (Direction == directionList[0])
            Direction = directionList[3];

        else if (Direction == directionList[3])
            Direction = directionList[2];

        else if (Direction == directionList[2])
            Direction = directionList[1];

        else if (Direction == directionList[1])
            Direction = directionList[0];

        if (watchRobotSteps == true)
            ViewWrite.LookToDirection(oldDirection, Direction);
    }
    public static void MoveOn(bool watchRobotSteps)
    {
        if (Direction == directionList[0])
            PositionY += 1;
        else if (Direction == directionList[2])
            PositionY -= 1;
        else if (Direction == directionList[3])
            PositionX += 1;
        else if (Direction == directionList[1])
            PositionX -= 1;

        if (watchRobotSteps == true)
        {
            ViewWrite.MovingOnPositions(PositionX, PositionY, Direction);
        }
    }
}
