namespace Lab_4;

class Pedals
{
    private int _speed;
        
    public void IncreaseSpeed(int speed)
    {
        _speed += speed;
        Console.WriteLine($"Speed was increased to {_speed} km/h");
    }
    public void DecreaseSpeed(int speed)
    {
        _speed -= speed;
        Console.WriteLine($"Speed was decreased to {_speed} km/h");
    }
    //---------------------------OVERRIDE----------------------------------
    public override string ToString()
    {
        return "It's method ToString in class Pedals";
    }

    public override bool Equals(object? obj)
    {
        return false;
    }

    public override int GetHashCode()
    {
        return 5;
    }
}