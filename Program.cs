var brain = new Brain(new IntakeSensor { });
var time2Sleep = false;
while (true)
{
    var observations = brain.Observe();
    var threadsOfDecisions = brain.Decide(observations);
    while (!time2Sleep)
    {
        observations = brain.Observe();
        threadsOfDecisions = brain.Decide(observations, threadsOfDecisions);
        time2Sleep = brain.IsSleepy(threadsOfDecisions);
    }
    brain.Sleep(threadsOfDecisions);
    time2Sleep = false;
}