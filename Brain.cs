// See https://aka.ms/new-console-template for more information
internal class Brain
{
    private IntakeSensor _intakeSensor;

    public Brain(IntakeSensor intakeSensor)
    {
        _intakeSensor = intakeSensor;
    }

    internal object Decide(object observations)
    {
        throw new NotImplementedException();
    }

    internal object Observe()
    {
        var perceivables = _intakeSensor.GetAllPerceivables();
        return perceivables;
    }

    internal void Sleep(object threadsOfDecisions)
    {
        throw new NotImplementedException();
    }

    internal bool IsSleepy(object threadsOfDecisions)
    {
        throw new NotImplementedException();
    }

    internal object Decide(object observations, object threadsOfDecisions)
    {
        throw new NotImplementedException();
    }

}