
using System.Numerics;

public interface INumArray1D<T>
    where T:INumber<T> 
{
    T? Aggregate(Func<T, T, T> fx) ;
    T? Sum();
    T? Min();
    T? Max();
    T? Product(bool IgnoreZeros=true);
    INumArray1D<T> Filter(Func<T, bool> fx);
    INumArray1D<R> Map<R>(Func<T, R> fx) where R:INumber<R>;
    R Reduce<R>(Func<T, R, R> fx);
    R Fold<R>(Func<T, R, R> fx, R acc);
}