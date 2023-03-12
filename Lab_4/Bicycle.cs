namespace Lab_4;

class Bicycle
{
    private Wheel _wheels = new Wheel();
    private Frame _frame = new Frame();
    private Helm _helm = new Helm();
    private Pedals _pedals = new Pedals();
    private BicycleImages _image = new BicycleImages();

    private string[] _images;
    
    public string Checker { get; set; }

    public Bicycle()
    {
        _images = _wheels.Images;
    }

    private void Ride()
    {
        char actionIndex;
        int colorIndex;
        char speedIndex;
        char rotationIndex;
        char action;
        char wheel;

        int speed;

        List<ConsoleColor> colors = new List<ConsoleColor>()
        {
            ConsoleColor.White,
            ConsoleColor.Blue,
            ConsoleColor.Yellow,
            ConsoleColor.Red,
            ConsoleColor.Green
        };

        Console.WriteLine(_images[_wheels.Index]);

        if (_wheels.Index != 3)
        {
            Construct();
        }
        else
        {
            Console.WriteLine("GOOD!");
            while (_wheels.Index == 3)
            {
                Console.WriteLine("Write action:\n1. Increase/Decrease speed\n2." +
                                  " Change color\n3. Rotate helm\n4. Change wheels");
                actionIndex = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (actionIndex)
                {
                    case '1':
                        Console.Write("You want increase or decrease speed? (i/d): ");
                        speedIndex = Convert.ToChar(Console.ReadLine());
                        if (speedIndex == 'i')
                        {
                            Console.WriteLine($"Your speed is {_pedals.Speed}");
                            Console.Write("Write speed to increase: ");
                            speed = Convert.ToInt32(Console.ReadLine());
                            if(_pedals.IncreaseSpeed(speed) >= 0)
                                Console.WriteLine($"Speed was increased to {_pedals.Speed} km/h");
                            else
                            {
                                Console.WriteLine("You cant ride with negative speed!");
                            }
                        }
                        else if (speedIndex == 'd')
                        {
                            Console.WriteLine($"Your speed is {_pedals.Speed}");
                            Console.Write("Write speed to decrease: ");
                            speed = Convert.ToInt32(Console.ReadLine());
                            if(_pedals.DecreaseSpeed(speed) >= 0)
                                Console.WriteLine($"Speed was decreased to {_pedals.DecreaseSpeed(speed)} km/h");
                            else
                            {
                                Console.WriteLine("You cant ride with negative speed!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect action!");
                        }
                        break;
                    case '2':
                        Console.WriteLine("Choose colour: ");
                        colorIndex = 0;
                        foreach (var color in colors)
                        {
                            Console.WriteLine($"{++colorIndex}. {color}");
                        }

                        colorIndex = Convert.ToInt32(Console.ReadLine());
                        if (colorIndex >0 && colorIndex<6)
                            _frame.ChangeColor(_images[_wheels.Index], colors[--colorIndex]);
                        else
                            Console.WriteLine("Incorrect index!");
                        break;
                    case '3':
                        Console.Write("Choose your rotation side (r/l): ");
                        rotationIndex = Convert.ToChar(Console.ReadLine());
                        _helm.Rotate(rotationIndex);
                        break;
                    case '4':
                        Console.Write("You want to remove or insert wheel? (r/i): ");
                        action = Convert.ToChar(Console.ReadLine());
                        Console.Write("Choose wheel (r/l): ");
                        wheel = Convert.ToChar(Console.ReadLine());
                        if (action == 'r')
                            _wheels.RemoveWheels(wheel);
                        else if (action == 'i')
                            _wheels.InsertWheels(wheel);
                        else
                            Console.WriteLine("Incorrect action!");
                        break;
                    default:
                        Console.WriteLine("Incorrect index!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            
            Construct();
        }
    }

    public void Construct()
    {
        Console.WriteLine(_images[_wheels.Index]);
        char action;
        char wheel;
        Console.WriteLine("Before ride, you should to construct your bicycle!");
        Console.ReadKey();
        Console.Clear();
        
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
                Console.WriteLine("Incorrect action!");
            Console.ReadKey();
            Console.Clear();
        }
        Ride();
    }
    //---------------------------OVERRIDE----------------------------------
    public override string? ToString()
    {
        if (string.IsNullOrEmpty(Checker))
            return base.ToString();
        return Checker;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Bicycle bicycle)
            return Checker == bicycle.Checker;
        return false;
    }

    public override int GetHashCode()
    {
        if (Checker != null) return Checker.GetHashCode();
        return 0;
    }
}