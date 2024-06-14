
    class Program
    {



        static void Main(string[] args)
        {


            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();

            Console.WriteLine(value);  

            Console.ReadKey(true);
        }



    }

