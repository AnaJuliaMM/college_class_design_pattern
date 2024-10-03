public class Intern : Colleague
{
    public Intern(IMediator mediator, string name) : base(mediator,name) { }


    public override void Notify(string message)
    {
        Console.WriteLine($"{this.GetType().Name}  {name} recebeu mensagem: {message}");
    }
}