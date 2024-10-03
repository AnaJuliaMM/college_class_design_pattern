public class SecurityProxy : IStudioAccess
{   
    private Studio Studio;

    public SecurityProxy (Studio studio)
    {
        this.Studio = studio;
    }

    public void EnterStudio(Visitor visitor)
    {
        if (visitor.HasVIPPass) 
            Studio.EnterStudio(visitor);
        else 
            Console.Write($"Desculpe {visitor}, o acesso aos bastidores é restrito apenas para visitantes VIP.");
        
    }
}