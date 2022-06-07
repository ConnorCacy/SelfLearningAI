// See https://aka.ms/new-console-template for more information
using SelfLearningAI.Sensors;

internal class IntakeSensor
{
    public List<Eye>? Eyes { get; set; }
    public List<Ear>? Ears { get; set; }
    internal List<Perceivable> GetAllPerceivables()
    {
        return new List<Perceivable> { };
    }
}