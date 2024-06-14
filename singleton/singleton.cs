namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Class1 c = Class1.getInstance();

        //     Class1 c2 = Class1.getInstance();
        //     c2.print("adsadasd");

            c.print("Hello world");
            Parallel.Invoke(
                () => method1(),
                () => method2()
                );

            Console.ReadKey(true);

        }

        public static void method1()
        {
            Class1 c = Class1.getInstance();
            c.print("Hello world");
        }

        public static void method2()
        {
            Class1 c2 = Class1.getInstance();
            c2.print("adsadasd");
           
        }
    }
}