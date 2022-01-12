using System.Collections.Generic;
using System.Linq;

namespace CallCenter.Queues;

public abstract class Queue
{
    protected string Name { get; set; }
    protected List<Call> ListOfCalls { get; set; }
    protected List<Agent> ListOfAgents { get; set; }

    public Queue(string name)
    {
        Name = name;
        ListOfAgents = new List<Agent>();
        ListOfCalls = new List<Call>();
    }

    public abstract void AddAgent(Agent newAgent);

    public Call LongestWaitingCall()
    {
        return ListOfCalls.First();
    }

    public int CallsCount()
    {
        return ListOfCalls.Count();
    }
}