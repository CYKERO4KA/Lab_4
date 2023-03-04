using System.Drawing;
namespace Lab_4;

class Program
{
    static void Main(string[] args)
    {
        Bicycle bicycle = new Bicycle();
        bicycle.Ride();
        Console.ReadKey();
    }
}