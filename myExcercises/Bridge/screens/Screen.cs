namespace Bridge.screens;

using shapes;

public abstract class Screen
{
    protected Shape shape;

    protected Screen(Shape shape)
    {
        this.shape = shape;
    }

    public void TurnOn()
    {
        Console.Write("Ligando a Tela");
    }

    public void TurnOff()
    {
        Console.Write("Desligando a Tela");
    }

    public abstract void Draw();
}


