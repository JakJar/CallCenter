using CallCenter.Employees;

namespace CallCenter.Queues;

public class NormalPriorityQueue : Queue
{
    public NormalPriorityQueue(string name) : base(name)
    {
    }

    public override void AddAgent(Agent newAgent)
    {
        ListOfAgents.Add(newAgent);
    }
}