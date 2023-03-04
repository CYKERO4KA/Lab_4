namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            Console.WriteLine(bicycle.ToString());
            Console.WriteLine(bicycle.Equals("sgfs"));
            Console.WriteLine(bicycle.GetHashCode());
            Console.ReadKey();

        }
    }

    class Bicycle
    {
        private Wheel _wheels;
        private Frame _frame;
        private Helm _helm;
        private Pedals _pedals;

        public void ReturnHelm()
        {
            
        }

        public void Ride()
        {
            
        }

        public void IncreaseSpeed()
        {
            
        }

        public void ChangeWheels()
        {
            
        }

        public void Draw()
        {
            
        }

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

    class Wheel
    {
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

    class Frame
    {
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

    class Helm
    {
        public void Rotate()
        {
            
        }
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

    class Pedals
    {
        public override string ToString()
        {
            return "It's method ToString in class Pedals";
        }

        public override bool Equals(object? obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 5;
        }
    }
}