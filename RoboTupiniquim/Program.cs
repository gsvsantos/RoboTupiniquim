using RoboTupiniquim.Entities;
using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim
{
    internal class Program
    {
        static Robot firstRobot = new Robot();
        static Robot secondRobot = new Robot();

        static void Main(string[] args)
        {
            do
            {
                ViewWrite.Header();
                Area.AreaCreate();

                ViewUtils.PressEnter("PRIMEIRO-ROBO");
                ViewWrite.Header();
                ViewWrite.PrintArea();

                firstRobot.GetData();
                firstRobot.GetCommands();

                ViewUtils.PressEnter("SEGUNDO-ROBO");
                ViewWrite.Header();
                ViewWrite.PrintArea();

                secondRobot.GetData();
                secondRobot.GetCommands();

                ViewUtils.PressEnter("POSICAO-FINAL");
                ViewWrite.Header();

                ViewWrite.LastPosition(firstRobot.Id, firstRobot.PositionX, firstRobot.PositionY, firstRobot.Direction);
                ViewWrite.LastPosition(secondRobot.Id, secondRobot.PositionX, secondRobot.PositionY, secondRobot.Direction);

                ViewUtils.PressEnter("LANCAR-NOVAMENTE");
            } while (true);
        }
    }
}
