namespace CallCenter;

public class Agent : Employee
{
    private AgentSeniority Seniority { get; set; }

    public Agent(string name, AgentSeniority seniority) : base(name)
    {
        Seniority = seniority;
    }

    public AgentSeniority GetSeniority()
    {
        return Seniority;
    }
}