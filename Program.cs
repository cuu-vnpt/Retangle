

internal class Program 
{


public static void Main(string[] args)
{
    Console.WriteLine("Nhap chieu rong hinh chu nhat");
    double width = double.Parse(Console.ReadLine());
    Console.WriteLine("Nhap chieu cao hinh chu nhat");
    double height = double.Parse(Console.ReadLine());

    Rectangle myRectangle = new Rectangle(width,height);

    myRectangle.PrintfArea();
    myRectangle.Perimeter();
}
}
