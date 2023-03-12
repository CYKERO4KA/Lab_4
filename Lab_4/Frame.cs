namespace Lab_4;

class Frame
{
    public string Checker { get; set; }
    
    public void ChangeColor(string frame, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(frame);
        Console.ForegroundColor = ConsoleColor.White;
        Console.ResetColor();
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
        if (obj is Frame frame)
            return Checker == frame.Checker;
        return false;
    }

    public override int GetHashCode()
    {
        if (Checker != null) return Checker.GetHashCode();
        return 0;
    }
}