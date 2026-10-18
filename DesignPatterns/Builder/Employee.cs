namespace DesignPatterns.Builder
{
    internal class Employee
    {
        private string name;
        private int age;
        private decimal salary;
        public int Id { get; }


        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public decimal Salary
        {
            get { return salary; }
        }
        public Employee AddName(string name)
        {
            this.name = name;
            return this;
        }
        public Employee AddAge(int age)
        {
            this.age = age;
            return this;
        }
        public Employee AddSalary(decimal salary)
        {
            this.salary = salary;
            return this;
        }
        public override string ToString()
        => $"ID :{Id} || Name : {name} || Age : {Age} || Salary : {salary}";

    }
}
