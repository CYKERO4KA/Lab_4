namespace Lab_4;

class Helm
{
    private int _index;    //i = 0 -- center, i = -1 -- left, i = 1 -- right
    public string Checker { get; set; }
    public void Rotate(char rotationSide)
    {
        if (rotationSide == 'r')
        {
            switch (_index)
            {
                case 0:
                    _index = 1;
                    Console.WriteLine("Your helm rotated to right!");
                    break;
                case 1:
                    Console.WriteLine("Your helm is already rotated to right!");
                    break;
                case -1:
                    _index = 0;
                    Console.WriteLine("Your helm rotated to center!");
                    break;
            }
        }
        else if (rotationSide == 'l')
        {
            switch (_index)
            {
                case 0:
                    _index = -1;
                    Console.WriteLine("Your helm rotated to left!");
                    break;
                case 1:
                    _index = 0;
                    Console.WriteLine("Your helm rotated to center!");
                    break;
                case -1:
                    Console.WriteLine("Your helm is already rotated to left!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Incorrect side!");
        }
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
        if (obj is Helm helm)
            return Checker == helm.Checker;
        return false;
    }

    public override int GetHashCode()
    {
        if (Checker != null) return Checker.GetHashCode();
        return 0;
    }
}