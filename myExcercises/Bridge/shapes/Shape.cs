namespace Bridge.shapes;

public abstract class Shape
{
    protected string color { get; set;}
    protected int x;
    protected int y;

    protected Shape(string color, int x, int y)
    {
        this.color = color;
        this.x = x;
        this.y = y;
    }

}