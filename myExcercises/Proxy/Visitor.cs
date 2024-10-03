public class Visitor
{
    private SecurityProxy SecurityProxy;
    public bool HasVIPPass { get; set;} 

    public Visitor(SecurityProxy securityProxy, bool hasVIPPass)
    {
        this.SecurityProxy = securityProxy;
        this.HasVIPPass = hasVIPPass;
    }

    public void AttemptToEnter()
    {
        SecurityProxy.EnterStudio(this);
    }

}