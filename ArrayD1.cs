namespace Solution;
public class Array1D<T> where T:IEquatable<T> 
{
    protected T[] _data=null!;
    protected int _index;

    public T[] data{ get => cloneArray(_data);}

    public Array1D(int size = 10) { 
        _data = new T[size];
        _index = 0;
    }

    public Array1D(T[] data) { 
        //Shallow or deep copy here
        //_data = data; //Shallow copy
        _data = cloneArray(data); //Deep Copy
        _index = data.Length;
    }

    public int Length => _data.Length;
    public int Count => _index;

    static T[] cloneArray(T[] srcArray)
    {
        if(srcArray == null) return null;
        var dstArray = new T[srcArray.Length];
        for(int i = 0; i < srcArray.Length; ++i)
        {
            dstArray[i] = srcArray[i];
        }
        return dstArray;
    }
}