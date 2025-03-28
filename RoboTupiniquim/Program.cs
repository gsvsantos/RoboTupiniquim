using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim
{
    internal class Program
    {
        static int firstRobotId = 1;
        static int secondRobotId = 2;
        static int robot1PosX, robot1PosY;
        static int robot2PosX, robot2PosY;
        static char robot1Direction, robot2Direction;
        static int areaMaxX, areaMaxY;

        static void Main(string[] args)
        {
            do
            {
                ViewWrite.Header();
                AreaCreate();

                ViewUtils.PressEnter("PRIMEIRO-ROBO");
                ViewWrite.Header();
                ViewWrite.PrintArea(areaMaxX, areaMaxY);

                GetData(firstRobotId);
                GetCommands(firstRobotId);

                ViewUtils.PressEnter("SEGUNDO-ROBO");
                ViewWrite.Header();
                ViewWrite.PrintArea(areaMaxX, areaMaxY);

                GetData(secondRobotId);
                GetCommands(secondRobotId);

                ViewUtils.PressEnter("POSICAO-FINAL");
                ViewWrite.Header();

                ViewWrite.LastPosition(firstRobotId, robot1PosX, robot1PosY, robot1Direction);
                ViewWrite.LastPosition(secondRobotId, robot2PosX, robot2PosY, robot2Direction);

                ViewUtils.PressEnter("LANCAR-NOVAMENTE");
            } while (true);
        }
        public static void AreaCreate()
        {
            string[] values = Validators.AreaLimitVerify();
            areaMaxX = Convert.ToInt32(values[0]);
            areaMaxY = Convert.ToInt32(values[1]);
        }
        public static bool RobotIsInside(int positionX, int positionY)
        {
            return positionX >= 0 && positionX <= areaMaxX && positionY >= 0 && positionY <= areaMaxY;
        }
        public static void GetData(int robotId)
        {
            string[] data = Validators.RobotDataVerify(robotId);
            if (robotId == firstRobotId)
            {
                robot1PosX = Convert.ToInt32(data[0]);
                robot1PosY = Convert.ToInt32(data[1]);
                robot1Direction = Convert.ToChar(data[2]);
            }
            else
            {
                robot2PosX = Convert.ToInt32(data[0]);
                robot2PosY = Convert.ToInt32(data[1]);
                robot2Direction = Convert.ToChar(data[2]);
            }
        }
        public static void GetCommands(int robotId)
        {
            do
            {
                char[] commands = Validators.RobotCommandsVerify();
                if (robotId == firstRobotId)
                {
                    Robot1RunCommands(commands);
                    return;
                }
                else if (robotId == secondRobotId)
                {
                    Robot2RunCommands(commands);
                    return;
                }
            } while (true);
        }
        private static void Robot1RunCommands(char[] commands)
        {
            do
            {
                ViewWrite.InitialPosition(robot1PosX, robot1PosY, robot1Direction);
                bool watchRobotSteps = ViewUtils.YesOrNo();
                Console.WriteLine();

                foreach (char command in commands)
                {
                    if (command == 'D')
                        robot1Direction = TurnRight(robot1Direction, watchRobotSteps);
                    else if (command == 'E')
                        robot1Direction = TurnLeft(robot1Direction, watchRobotSteps);
                    else if (command == 'M')
                    {
                        robot1PosX = MoveOnPositionX(robot1PosX, robot1PosY, robot1Direction, watchRobotSteps);
                        robot1PosY = MoveOnPositionY(robot1PosX, robot1PosY, robot1Direction, watchRobotSteps);
                    }
                }
                if (!RobotIsInside(robot1PosX, robot1PosY))
                {
                    ViewWriteErrors.InvalidLastPosition();
                    ViewWrite.RobotOutAreaActualPosition(firstRobotId, robot1PosX, robot1PosY, robot1Direction);
                    continue;
                }
                else
                    break;
            } while (true);
        }
        private static void Robot2RunCommands(char[] commands)
        {
            do
            {
                ViewWrite.InitialPosition(robot2PosX, robot2PosY, robot2Direction);
                bool watchRobotSteps = ViewUtils.YesOrNo();
                Console.WriteLine();

                foreach (char c in commands)
                {
                    if (c == 'D')
                        robot2Direction = TurnRight(robot2Direction, watchRobotSteps);
                    else if (c == 'E')
                        robot2Direction = TurnLeft(robot2Direction, watchRobotSteps);
                    else if (c == 'M')
                    {
                        robot2PosX = MoveOnPositionX(robot2PosX, robot2PosY, robot2Direction, watchRobotSteps);
                        robot2PosY = MoveOnPositionY(robot2PosX, robot2PosY, robot2Direction, watchRobotSteps);
                    }
                }
                if (!RobotIsInside(robot2PosX, robot2PosY))
                {
                    ViewWriteErrors.InvalidLastPosition();
                    ViewWrite.RobotOutAreaActualPosition(firstRobotId, robot2PosX, robot2PosY, robot2Direction);
                    continue;
                }
                else
                    break;
            } while (true);
        }
        public static char TurnLeft(char direction, bool watchRobotSteps)
        {
            char oldDirection = direction;

            if (direction == 'N')
                direction = 'O';
            else if (direction == 'O')
                direction = 'S';
            else if (direction == 'S')
                direction = 'L';
            else if (direction == 'L')
                direction = 'N';

            if (watchRobotSteps == true)
                ViewWrite.LookToDirection(oldDirection, direction);

            return direction;
        }
        public static char TurnRight(char direction, bool watchRobotSteps)
        {
            char oldDirection = direction;

            if (direction == 'N')
                direction = 'L';
            else if (direction == 'L')
                direction = 'S';
            else if (direction == 'S')
                direction = 'O';
            else if (direction == 'O')
                direction = 'N';

            if (watchRobotSteps == true)
                ViewWrite.LookToDirection(oldDirection, direction);

            return direction;
        }
        public static int MoveOnPositionX(int positionX, int positionY, char direction, bool watchRobotSteps)
        {
            if (direction == 'L')
                positionX += 1;
            else if (direction == 'O')
                positionX -= 1;

            return positionX;
        }
        public static int MoveOnPositionY(int positionX, int positionY, char direction, bool watchRobotSteps)
        {
            if (direction == 'N')
                positionY += 1;
            else if (direction == 'S')
                positionY -= 1;

            if (watchRobotSteps == true)
            {
                ViewWrite.MovingOnPositions(positionX, positionY, direction);
            }

            return positionY;
        }

    }
}
