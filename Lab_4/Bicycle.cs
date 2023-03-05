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
        
        if(_wheels.Index != 3) Construct();
        else
        {
            Console.WriteLine("GOOD!");
            while (true)
            {
                
            }
        }
        
    }

    private void Construct()
    {
        char action;
        char wheel;
        Console.WriteLine("Before ride, you should to construct your bicycle!");
        while (_wheels.Index != 3)
        {
            Console.Write("You want to remove or insert wheel? (r/i): ");
            action = Convert.ToChar(Console.ReadLine());
            Console.Write("Choose wheel (r/l): ");
            wheel = Convert.ToChar(Console.ReadLine());
            if (action == 'r')
                _wheels.RemoveWheels(wheel);
            else if (action == 'i')
                _wheels.InsertWheels(wheel);
            else
                Console.WriteLine("ERROR!");
            Console.ReadKey();
            Console.Clear();
        }
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