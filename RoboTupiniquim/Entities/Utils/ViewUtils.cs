namespace RoboTupiniquim.Entities.Utils;

internal class ViewUtils
{
    public static int GetAreaMaxLimit()
    {
        int input = Validators.IntVerify("\nPor favor, digite o tamanho da área de pesquisa (Ex: 5 5): ", 1);
        return input;
    }
    public static string[] GetRobotInitialData()
    {
        string input = Validators.StringVerify("Informe a posição inicial do Robô: ", "Houve um erro com esta posição informada!", 1, 5);
        return input.ToUpper().Split(' ');
    }
    public static char[] GetCommandList()
    {
        string input = Validators.StringVerify("Informe os comandos de movimentos: ", "Este comando está um pouco pequeno..", 1);
        return input.ToUpper().ToCharArray();
    }
    public static void PressEnter(string type)
    {
        switch (type)
        {
            case "TENTAR-NOVAMENTE":
                ViewColors.PaintWrite("\nPressione [Enter] para tentar novamente.", ConsoleColor.Yellow);
                Console.ReadKey();
                break;
            case "USAR-NOVAMENTE":
                ViewColors.PaintWrite("\nPressione [Enter] para usar novamente.", ConsoleColor.Yellow);
                Console.ReadKey();
                break;
        }
    }
}
