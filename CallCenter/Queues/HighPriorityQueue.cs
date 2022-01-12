using CallCenter.Employees;

namespace CallCenter.Queues;

public class HighPriorityQueue : Queue
{
    public HighPriorityQueue(string name) : base(name)
    {
    }

    public override void AddAgent(Agent newAgent)
    {
        if (newAgent.GetSeniority() == Agent.AgentSeniority.Level3)
        {
            ListOfAgents.Add(newAgent);
        }
    }
}