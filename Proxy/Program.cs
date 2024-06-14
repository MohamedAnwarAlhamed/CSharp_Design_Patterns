
    class Program
    {

        public class Client
        {
            public void ClientCode(ISubject subject)
            {
                // ...

                subject.Request();

                // ...
            }
        }

        static void Main(string[] args)
        {

            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            Subject realSubject = new Subject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            TheProxy proxy = new TheProxy(realSubject);
            client.ClientCode(proxy);


            Console.ReadKey(true);
        }



    }

