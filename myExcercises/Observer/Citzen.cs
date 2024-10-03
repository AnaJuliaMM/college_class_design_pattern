// Classe concreta Observer
public class Citzen : IObserver
{
    private string Name;

    public Citzen(string name)
    {
        this.Name = name;
    }

    public void Update(Event magicEvent)
    {
        Console.WriteLine($"Notificação para {this.Name}: {magicEvent}");
    }
}