namespace Lab_4;

class Helm
{
    public void Rotate(char rotationSide)
    {
        switch (rotationSide)
        {
            case 'r':
                Console.WriteLine("helm returned to right!");
                break;
            case 'l':
                Console.WriteLine("helm returned to left!");
                break;
            default:
                Console.WriteLine("ERROR!");
                break;
        }
    }
    //---------------------------OVERRIDE----------------------------------
    public override string ToString()
    {
        return "It's method ToString in class Helm";
    }

    public override bool Equals(object? obj)
    {
        return true;
    }

    public override int GetHashCode()
    {
        return 4;
    }
}