using System.Collections.Generic;
using CallCenter.Employees;
using CallCenter.Queues;

namespace CallCenter;

public class CallCenter
{
    private List<Agent> CallCenterAgents { get; set; }
    private List<Call> ComingCalls { get; set; }
    private HighPriorityQueue HighPriorityQueue { get; set; }
    private NormalPriorityQueue NormalPriorityQueue { get; set; }

    public Queue MostCallsQueue()
    {
        return HighPriorityQueue.CallsCount() > NormalPriorityQueue.CallsCount() ? HighPriorityQueue : NormalPriorityQueue;
    }
}