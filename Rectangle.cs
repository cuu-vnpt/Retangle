public class Rectangle
{
    double width, height;

    public Rectangle()
    {

    }
    public Rectangle(double width, double height)
    {
        this.width=width;
        this.height=height;
    }
    public void PrintfArea()
    {
        Console.WriteLine("Dien tich la: " + this.width*this.height);
    }
    public void Perimeter()
    {
        Console.WriteLine("Chu vi la: " +(this.width + this.height)*2 );
    }
}