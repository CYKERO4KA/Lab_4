namespace Lab_4;

class Wheel      
{
    private BicycleImages _images = new BicycleImages();
    private int _index = 0;  //(i = 0 -- 0 wheels), (i = 1 -- only left wheel), (i = 2 -- only right wheel), (i = 3 -- all wheels)

    private string[] _image;
    
    public string Checker { get; set; }

    public Wheel()
    {
        _image = new[]
        {
            _images.DrawNullWheelBicycle(),
            _images.DrawLeftWheelBicycle(), 
            _images.DrawRightWheelBicycle(),
            _images.DrawFullBicycle()
        };
    }

    public int Index
    {
        get => _index;
    }
    public string[] Images
    {
        get => _image;
    }

    public void InsertWheels(char wheel)
    {
        if (wheel == 'r')
        {
            if (_index == 0)
            {
                _index = 2;
                Output();
            }
            else if (_index == 1)
            {
                _index = 3;
                Output();
            }
            else if (_index == 2)
            {
                Output();
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
                _index = 1;
                Output();
            }
            else if (_index == 1)
            {
                Output();
                Console.WriteLine("Left wheel is already stands");
            }
            else if (_index == 2)
            {
                _index = 3;
                Output();
            }
            else if (_index == 3)
            {
                Console.WriteLine("All wheels are already stands");
            }
        }
        else
        {
            Console.WriteLine("Incorrect wheel!");
        }
    }
    public void RemoveWheels(char wheel)    //(i = 0 -- 0 wheels), (i = 1 -- only left wheel), (i = 2 -- only right wheel), (i = 3 -- all wheels)
    {
        if (wheel == 'r')
        {
            if (_index == 0)
            {
                Output();
                Console.WriteLine("There is already zero wheels!");
            }
            else if (_index == 1)
            {
                Output();
                Console.WriteLine("There is already no right wheel!");
            }
            else if (_index == 2)
            {
                _index = 0;
                Output();
            }
            else if (_index == 3)
            {
                _index = 1;
                Output();
            }
        }
        else if (wheel == 'l')
        {
            if (_index == 0)
            {
                Output();
                Console.WriteLine("There is already zero wheels!");
            }
            else if (_index == 1)
            {
                _index = 0;
                Output();
            }
            else if (_index == 2)
            {
                Output();
                Console.WriteLine("There is already no left wheel!");
            }
            else if (_index == 3)
            {
                _index = 2;
                Output();
            }
        }
        else
        {
            Console.WriteLine("Incorrect wheel!");
        }
    }

    private void Output()
    {
        Console.WriteLine(_image[_index]);
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
        if (obj is Wheel wheel)
            return Checker == wheel.Checker;
        return false;
    }

    public override int GetHashCode()
    {
        if (Checker != null) return Checker.GetHashCode();
        return 0;
    }
}