namespace RoboTupiniquim.Entities;

internal class Robot : Entity
{
    public static int id = 0;
    public Robot() { }
    public override void TurnLeft(bool watchRobotSteps)
    {
        base.TurnLeft(watchRobotSteps);
    }
    public override void TurnRight(bool watchRobotSteps)
    {
        base.TurnRight(watchRobotSteps);
    }
    public override void MoveOn(bool watchRobotSteps)
    {
        base.MoveOn(watchRobotSteps);
    }
    public override void GetData(int id)
    {
        base.GetData(id);
    }
}
