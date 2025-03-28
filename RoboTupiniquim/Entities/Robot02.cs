namespace RoboTupiniquim.Entities;

public class Robot02 : Entity
{
    public int Id = 2;
    public Robot02() { }
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
