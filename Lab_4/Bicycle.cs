namespace Lab_4;

class Bicycle
{
    private Wheel _wheels = new Wheel();
    private Frame _frame = new Frame();
    private Helm _helm = new Helm();
    private Pedals _pedals = new Pedals();
    private BicycleImages _images = new BicycleImages();
    public void Ride()
    {
            
        _frame.ChangeColor(_images.DrawNullWheelBicycle(), ConsoleColor.White);

    }
    //---------------------------OVERRIDE----------------------------------
    public override string ToString()
    {
        return "It's method ToString in class Bicycle";
    }

    public override bool Equals(object? obj)
    {
        return true;
    }

    public override int GetHashCode()
    {
        return 1;
    }
}