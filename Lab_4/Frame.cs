namespace Lab_4;

class Frame
{
    public void ChangeColor(string frame, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(frame);
        Console.ForegroundColor = ConsoleColor.White;
        Console.ResetColor();
    }
        
        
        
        
    //---------------------------OVERRIDE----------------------------------
    public override string ToString()
    {
        return "It's method ToString in class Frame";
    }

    public override bool Equals(object? obj)
    {
        return true;
    }

    public override int GetHashCode()
    {
        return 3;
    }
}