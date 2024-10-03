namespace Bridge.screens;

using shapes;
public class UniversalScreen: Screen
{
    public UniversalScreen(Shape shape) : base(shape) { }

    
    public override void Draw()
    {
        Console.Write($"Desenhando {shape} ");
    }
}