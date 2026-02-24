using System.Numerics;

namespace Solution;
public class NumArray1D<T> : Array1D<T>, INumArray1D<T> where T : IComparable<T>, INumber<T>
{
    public NumArray1D(int size = 10):base(size) {  }
    public NumArray1D(T[] data):base(data) { }
  
  //ToDo

    public T? Aggregate(Func<T, T, T> fx)
    {
        if (_data.Length == 0)
            return default;

        T aggregate = _data[0];

        for (int i = 1; i < _data.Length; i++)
        {
            aggregate = fx(aggregate, _data[i]);
        }

        return aggregate;
    }

    public T? Max()
    {
        throw new NotImplementedException();
    }

    public T? Min()
    {
        throw new NotImplementedException();
    }

    public T? Product(bool IgnoreZeros = true)
    {
        throw new NotImplementedException();
    }

    public T? Sum()
    {
        throw new NotImplementedException();
    }

    public INumArray1D<T> Filter(Func<T, bool> fx)
    {
        throw new NotImplementedException();
    }

    public INumArray1D<R> Map<R>(Func<T, R> fx) where R : INumber<R>
    {
        throw new NotImplementedException();
    }

    public R Reduce<R>(Func<T, R, R> fx)
    {
        throw new NotImplementedException();
    }

    public R Fold<R>(Func<T, R, R> fx, R acc)
    {
        throw new NotImplementedException();
    }
}