class Cell
{
    public Cell() { }

    public Cell(int val)
    {
        value = val;
    }

    public int value;
    public int divide(Cell cell)
    {
        if (cell.value == 0 && value == 0)
        {
            throw new ZeroByZeroException("Divide zero by zero");
        }
        else if (cell.value == 0){
            throw new DivideByZeroException("DivideByZero");
        }
        return value / cell.value;
    }
}

class ZeroByZeroException:Exception
{
    public ZeroByZeroException(string message): base(message) {}
}

class SuperProgram
{
    public static void Main()
    {
        Cell cell = new Cell(0);
        Cell cell2 = new Cell(0);

        try
        {
            cell.divide(cell2);
        }
        catch (ZeroByZeroException)
        {
            Console.WriteLine("Zero by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
