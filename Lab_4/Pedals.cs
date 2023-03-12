namespace Lab_4;
class Pedals
{
    private int _speed;
    public string Checker { get; set; }
    
    public int Speed
    {
        get => _speed;
    }
    public int IncreaseSpeed(int speed)
    {
        if(_speed + speed >= 0)
            return _speed += speed;
        return 0;
        
    }
    public int DecreaseSpeed(int speed)
    {
        if(_speed - speed >= 0)
            return _speed -= speed;
        return 0;
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
        if (obj is Pedals pedals)
            return Checker == pedals.Checker;
        return false;
    }

    public override int GetHashCode()
    {
        if (Checker != null) return Checker.GetHashCode();
        return 0;
    }
}