var brain =
    new Brain(new IntakeSensor
    {
        Ears = new List<SelfLearningAI.Sensors.Ear> { },
        Eyes = new List<SelfLearningAI.Sensors.Eye> { },
    });

var time2Sleep = false;
while (true)
{
    var observations = brain.Observe();
    var threadsOfDecisions = brain.Decide(observations);
    while (!time2Sleep)
    {
        observations = brain.Observe();
        threadsOfDecisions = brain.Decide(observations, threadsOfDecisions);
        time2Sleep = brain.NeedsSleep(threadsOfDecisions);
    }
    brain.Sleep(threadsOfDecisions);
    time2Sleep = false;
}