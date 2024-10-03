public class Studio : IStudioAccess
{
    private string Name;
    public Studio(string name)
    {
        this.Name = name;
    }

    public void EnterStudio(Visitor visitor)
    {
        Console.WriteLine($"{visitor}, bem-vindo ao estúdio! Você pode conhecer os atores e assistir cenas exclusivas do filme!");
    }
}