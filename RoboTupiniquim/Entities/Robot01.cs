namespace RoboTupiniquim.Entities;

public class Robot01 : Entity
{
    public int Id = 1;
    public Robot01() { }
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
