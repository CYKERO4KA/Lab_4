namespace Lab_4;

class Wheel      
{
    private BicycleImages _images = new BicycleImages();
    private int _index = 0;  //(i = 0 -- 0 wheels), (i = 1 -- only left wheel), (i = 2 -- only right wheel), (i = 3 -- all wheels)
    
    public int Index
    {
        get => _index;
    }

    public void AddWheels(char wheel)
    {
        if (wheel == 'r')
        {
            if (_index == 0)
            {
                Console.WriteLine(_images.DrawRightWheelBicycle());
                _index = 2;
            }
            else if (_index == 1)
            {
                Console.WriteLine(_images.DrawFullBicycle());
                _index = 3;
            }
            else if (_index == 2)
            {
                Console.WriteLine("Right wheel is already stands");
            }
            else if (_index == 3)
            {
                Console.WriteLine("All wheels are already stands");
            }
        }
        else if (wheel == 'l')
        {
            if (_index == 0)
            {
                Console.WriteLine(_images.DrawLeftWheelBicycle());
                _index = 1;
            }
            else if (_index == 1)
            {
                Console.WriteLine("Left wheel is already stands");
            }
            else if (_index == 2)
            {
                Console.WriteLine(_images.DrawFullBicycle());
                _index = 3;
            }
            else if (_index == 3)
            {
                Console.WriteLine("All wheels are already stands");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public void RemoveWheels(char wheel)
    {
        if (wheel == 'r')
        {
            if (_index == 0)
            {
                Console.WriteLine(_images.DrawRightWheelBicycle());
                _index = 2;
            }
            else if (_index == 1)
            {
                Console.WriteLine(_images.DrawFullBicycle());
                _index = 3;
            }
            else if (_index == 2)
            {
                Console.WriteLine("Right wheel is already stands");
            }
            else if (_index == 3)
            {
                Console.WriteLine("All wheels are already stands");
            }
        }
        else if (wheel == 'l')
        {
            if (_index == 0)
            {
                Console.WriteLine(_images.DrawLeftWheelBicycle());
                _index = 1;
            }
            else if (_index == 1)
            {
                Console.WriteLine("Left wheel is already stands");
            }
            else if (_index == 2)
            {
                Console.WriteLine(_images.DrawFullBicycle());
                _index = 3;
            }
            else if (_index == 3)
            {
                Console.WriteLine("All wheels are already stands");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    //---------------------------OVERRIDE----------------------------------
    public override string ToString()
    {
        return "It's method ToString in class Wheel";
    }

    public override bool Equals(object? obj)
    {
        return false;
    }

    public override int GetHashCode()
    {
        return 2;
    }
}