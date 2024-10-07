using System.Runtime.CompilerServices;

class MagicException : ArgumentException
{
    public int Value { get; }
    public MagicException(string message, int value): base(message)
    {
        Value = value;
    }
}

class Student
{
    public string Name { get; set; }
    private int _score;

    public int Score
    {
        get { return _score; }
        set
        {
            _score = value / 2;
            if (value < 20)
            {
                throw new MagicException($"Score {value} is lower than 20!", value);
            }
            else
            {
                _score = value;
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        try
        {
            Student student = new Student { Name = "Yaroslav", Score = 5 };
        }
        catch(MagicException ex)
        {
            Console.WriteLine("MagicException");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception");
        }
    }
}
