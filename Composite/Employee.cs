
namespace singleton.Composite
{
    class Employee : IEmployee
    {
        public Employee(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
        }

        public string Name { get; set; }
        public string Department { get; set; }

        public void GetDetails(int indentation)
        {
            Console.WriteLine(string.Format("{0}- Name:{1}, Dept:{2} (Leaf) ",
                                   new String('-', indentation), this.Name.ToString(),
                                 this.Department));
        }
    }
}
