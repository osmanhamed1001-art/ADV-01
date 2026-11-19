namespace Advanced01
{


    #region 1
    //public class Box<T>
    //{
    //    public T Value { get; set; }

    //    public void Display()
    //    {
    //        Console.WriteLine(Value);
    //    }
    //} 
    #endregion
    #region 2

    //class Container<T>
    //{
    //    private T item;

    //    public void Add(T value)
    //    {
    //        item = value;
    //    }

    //    public T Get()
    //    {
    //        return item;
    //    }
    //}


    #endregion
    #region 3
    //public class Pair<TKey, TValue>
    //{
    //    public TKey Key { get; set; }
    //    public TValue Value { get; set; }
    //}
    #endregion
    #region 4
    //class Program
    //{
    //    public static void Swap<T>(ref T a, ref T b)
    //    {
    //        T temp = a;
    //        a = b;
    //        b = temp;
    //    }

    //    static void Main()
    //    {
    //        int x = 10;
    //        int y = 20;

    //        Swap(ref x, ref y);

    //        Console.WriteLine("X = " + x);
    //        Console.WriteLine("Y = " + y);
    //    }
    //}
    #endregion
    #region 5

    //class Program
    //{
    //    static T FindMax<T>(T a, T b) where T : IComparable<T>
    //    {
    //        return a.CompareTo(b) > 0 ? a : b;
    //    }

    //    static void Main()
    //    {
    //        int result = FindMax(10, 20);

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion
    #region 7
    //public class Container<T> where T : struct
    //{
    //    public T Value { get; set; }

    //    public Container(T value)
    //    {
    //        Value = value;
    //    }
    //}

    #endregion
    #region 8
    //public class Container<T> where T : class
    //{
    //    public T Value { get; set; }

    //    public Container(T value)
    //    {
    //        Value = value;
    //    }
    //}
    #endregion
    #region 9
    //public class Container<T> where T : new()
    //{
    //    public T Create()
    //    {
    //        return new T();
    //    }
    //}
    #endregion
    #region 10
    //public interface IPrintable
    //{
    //    void Print();
    //}

    //public class Container<T> where T : IPrintable
    //{
    //    public void Display(T item)
    //    {
    //        item.Print();
    //    }
    //}
    #endregion
    #region 11
    //public class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Animal is eating");
    //    }
    //}

    //public class Container<T> where T : Animal
    //{
    //    public void Display(T item)
    //    {
    //        item.Eat();
    //    }
    //}
    #endregion
    #region 13
    //public class Container<T>
    //{
    //    public T GetDefault()
    //    {
    //        return default(T);
    //    }
    //}

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
