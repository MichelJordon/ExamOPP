public class Circle : Shape
{
    protected double radius = 1.0;
    public Circle(){}
    public Circle( double radius )
    {
        this.radius = radius;
    }
    public Circle( double radius, Color color, bool filled )
    {
        this.radius = radius;
        this.color = color;
        this.filled = filled;
    }
    public double GetRadius()
    {
        return radius;
    }
    public double GetArea()
    {
        return Math.PI * radius*radius;
    }
    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
    
}