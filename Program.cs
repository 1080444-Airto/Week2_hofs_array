
using Solution;
//using ToDo;

class MainClass
{
    static void Main()
    {
        DebugArray();
    }
    
    static void DebugArray()
    {
        var data = new int[] { 10, 1, 5, 7, 0, -3, 100, 5 };
        INumArray1D<int> IArr1D = new NumArray1D<int>(data);

        var sum1 = IArr1D.Aggregate((a,b) => a + b);
        var sum2 = IArr1D.Reduce<double>((a,b) => a + b);
        var sum3 = IArr1D.Reduce<int>((a,b) => a + b);
        var sum5 = IArr1D.Reduce<double>((a,b) => a + b);

        var max = IArr1D.Fold<double>((a,b) => a > b? a : b, (IArr1D as NumArray1D<int>).data[0]);
        var min = IArr1D.Fold<int>((a,b) => a < b? a : b, (IArr1D as NumArray1D<int>).data[0]);

        var even = IArr1D.Filter(_ => _ % 2 == 0);
        var multiplied = IArr1D.Map(_ => _ * 2);
        System.Console.WriteLine($"\nnumbers:\n{String.Join(", ", (IArr1D as NumArray1D<int>).data)}");
        System.Console.WriteLine($"\neven numbers:\n{String.Join(", ", (even as NumArray1D<int>).data)}");
        System.Console.WriteLine($"\nmultiplied numbers:\n{String.Join(", ", (multiplied as NumArray1D<int>).data)}");

        System.Console.WriteLine();
    }
}