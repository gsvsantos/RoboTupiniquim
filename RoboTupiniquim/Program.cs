using RoboTupiniquim.Entities;
using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim
{
    internal class Program
    {
        static Robot01 firstRobot = new Robot01();
        static Robot02 secondRobot = new Robot02();

        static void Main(string[] args)
        {
            ViewWrite.Header();
            Area.AreaCreate();
            ViewWrite.PrintArea();

            firstRobot.GetData(firstRobot.Id);
            firstRobot.GetCommands();

            secondRobot.GetData(secondRobot.Id);
            secondRobot.GetCommands();

            ViewWrite.LastPosition(firstRobot.Id, firstRobot.PositionX, firstRobot.PositionY, firstRobot.Direction);
            ViewWrite.LastPosition(secondRobot.Id, secondRobot.PositionX, secondRobot.PositionY, secondRobot.Direction);

            ViewUtils.PressEnter("USAR-NOVAMENTE");
        }
    }
}
