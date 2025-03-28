using RoboTupiniquim.Entities;
using RoboTupiniquim.Entities.Utils;

namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ViewWrite.Header();
                Area.AreaCreate();

                ViewUtils.PressEnter("PRIMEIRO-ROBO");
                ViewWrite.Header();
                ViewWrite.PrintArea();

                Robot01.GetData();
                Robot01.GetCommands();

                ViewUtils.PressEnter("SEGUNDO-ROBO");
                ViewWrite.Header();
                ViewWrite.PrintArea();

                Robot02.GetData();
                Robot02.GetCommands();

                ViewUtils.PressEnter("POSICAO-FINAL");
                ViewWrite.Header();

                ViewWrite.LastPosition(Robot01.Id, Robot01.PositionX, Robot01.PositionY, Robot01.Direction);
                ViewWrite.LastPosition(Robot02.Id, Robot02.PositionX, Robot02.PositionY, Robot02.Direction);

                ViewUtils.PressEnter("LANCAR-NOVAMENTE");
            } while (true);
        }
    }
}
