using Microsoft.CSharp.RuntimeBinder;

class Program {
    public static void Main() {
        var a = 1000;
        Console.Writeline("Type a: {0}", a.GetType());

        a = int.Parse("10000");
        Console.Writeline("Type a: {0}", a.GetType());

        dynamic b = 1000;
        Console.Writeline("Type b: {0}", b.GetType());

        b = "1000";
        Console.Writeline("Type be after casting: {0}", b.GetType())

        b = double.Parse(b);
        Console.Writeline("Type be after casting 2: {0}", b.GetType())

        try {
            Console.Writeline("Length: (0)", b.Length);
        }
        catch (RuntimeBinderException ex) {
            Console.Writeline("Error: {0}", ex.Mwssage);
        }
    }
}