public abstract class Event
{
    public string time  { get; set;}
    public string location  {  get;  set;}

    public Event (string time, string location ) {
        this.time = time;
        this.location = location;
    }
}

