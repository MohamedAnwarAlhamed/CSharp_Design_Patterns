
sealed class Class1
{
    private static int counter;
    // private static Class1 Instance = null; 
    private static Class1 Instance = new Class1(); 

    private static readonly object obj =  new object ();
    private static readonly Lazy<Class1> instance = new Lazy<Class1>(() => new Class1());

    private Class1()
    {
        counter += 1;
        Console.WriteLine(" Instance Number" + counter.ToString());
    }

    public static Class1 getInstance()
    {
        // if (instance == null)
        // {
        //     lock (obj)
        //     {
        //         if (instance == null)
        //             instance new Class1();
        //     }
        //     return instance;
        // }
        // return instance;
        return instance.Value;
    }
    public void print(string msg)
    {
        Console.WriteLine(msg);
    }
}