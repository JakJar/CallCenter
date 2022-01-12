using System.Collections.Generic;
using System.Linq;

namespace CallCenter;

public class Queue
{
    private TypeOfQueue QueueType { get; set; }
    private string Name { get; set; }
    private List<Call> ListOfCalls { get; set; }
    private List<Agent> ListOfAgents { get; set; }

    public Queue(TypeOfQueue queueType, string name)
    {
        QueueType = queueType;
        Name = name;
        ListOfAgents = new List<Agent>();
        ListOfCalls = new List<Call>();
    }

    public void AddAgent(Agent newAgent)
    {
        if (QueueType == TypeOfQueue.HighPriority)
        {
            if (newAgent.GetSeniority() == AgentSeniority.Level3)
            {
                ListOfAgents.Add(newAgent);
            }
        }
        ListOfAgents.Add(newAgent);
    }

    public Call LongestWaitingCall()
    {
        return ListOfCalls.First();
    }

    public int CallsCount()
    {
        return ListOfCalls.Count();
    }
}