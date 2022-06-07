// See https://aka.ms/new-console-template for more information
using SelfLearningAI;

internal class Brain
{
    private IntakeSensor _intakeSensor;
    private Memory _memory;
    private Moods _mood;

    public int ThreadMistakeThreshold { get; private set; }

    public enum Moods
    {
        Happy,
        Sad,
        Frustrated
    }
    public Brain(IntakeSensor intakeSensor)
    {
        _intakeSensor = intakeSensor;
        _memory = new Memory();
    }



    internal List<Perceivable> Observe()
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
        var isSleepy = false;
        var mistakesCount = CheckMistakeCount(threadsOfDecisions);
        if (mistakesCount > ThreadMistakeThreshold)
        {
            if (_memory.IsFaulting() || _mood == Moods.Frustrated) isSleepy = true;
        }
        else if (_memory.IsLateAndTomorrowBigDay() || 
            _memory.IsLateAndThreadsNotImportant(threadsOfDecisions))
        {
            isSleepy = true;
        }
        return isSleepy;
    }

    private int CheckMistakeCount(object threadsOfDecisions)
    {
        throw new NotImplementedException();
    }

    internal List<BrainAction> Decide(List<Perceivable> observations)
    {
        return Decide(observations, null);
    }
    internal List<BrainAction> Decide(List<Perceivable> observations, object threadsOfDecisions)
    {
        _memory.SaveRelevantObservations(observations);
        return new List<BrainAction> { };
    }

}