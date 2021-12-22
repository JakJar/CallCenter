namespace CallCenter;

public class CallCenter
{
    private List<Agent> CallCenterAgents { get; set; }
    private List<Call> ComingCalls { get; set; }
    private Queue FirstQueue { get; set; }
    private Queue SecondQueue { get; set; }

    public Queue MostCallsQueue()
    {
        return FirstQueue.CallsCount() > SecondQueue.CallsCount() ? FirstQueue : SecondQueue;
    }
}