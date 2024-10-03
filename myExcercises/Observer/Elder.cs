// Classe concreta Subject
public class Elder : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    private Event Event { get;}

    public Elder(Event magicEvent)
    {
        this.Event = magicEvent;
    }

    public void SetEvent(string location="", string time="")
    {
        this.Event.location = location;
        this.Event.time = time;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(this.Event);
        }
    }
}
