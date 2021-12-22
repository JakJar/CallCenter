namespace CallCenter;

public class Call
{
    private DateTime CallTime { get; set; }
    private bool Accepted { get; set; }

    public Call()
    {
        CallTime = DateTime.Now;
        Accepted = false;
    }
}