using System;

public interface ICapital
{
    int Population { get; set; }
}

namespace Namespace1
{
    public class MyClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from Namespace1");
        }
    }
}

namespace Namespace2
{
    public class MyClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from Namespace2");
        }
    }
}

namespace Company
{
    namespace Department
    {
        public class Employee
        {
            public void ShowDepartment()
            {
                Console.WriteLine("Employee belongs to Sales Department");
            }
        }
    }
}

namespace MathOperations
{
    public class Operations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}

namespace StringOperations
{
    public class Operations
    {
        public string Concatenate(string a, string b)
        {
            return a + b;
        }
    }
}

namespace Country1
{
    public class Capital : ICapital
    {
        public int Population { get; set; }

        public Capital(int population)
        {
            Population = population;
        }
    }
}

namespace Country2
{
    public class Capital : ICapital
    {
        public int Population { get; set; }

        public Capital(int population)
        {
            Population = population;
        }
    }
}

namespace Country3
{
    public class Capital : ICapital
    {
        public int Population { get; set; }

        public Capital(int population)
        {
            Population = population;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        Namespace1.MyClass obj1 = new Namespace1.MyClass();
        obj1.PrintMessage();

        Namespace2.MyClass obj2 = new Namespace2.MyClass();
        obj2.PrintMessage();

        //Task 2
        Company.Department.Employee employee = new Company.Department.Employee();
        employee.ShowDepartment();

        //Task 3
        MathOperations.Operations mathOps = new MathOperations.Operations();
        int sum = mathOps.Add(3, 4);
        Console.WriteLine("Sum: " + sum);

        StringOperations.Operations stringOps = new StringOperations.Operations();
        string concatenated = stringOps.Concatenate("Hello, ", "World!");
        Console.WriteLine("Concatenated String: " + concatenated);

        //Task 4
        ICapital capital1 = new Country1.Capital(5000000);
        ICapital capital2 = new Country2.Capital(7000000);
        ICapital capital3 = new Country3.Capital(3000000);

        Console.WriteLine("Population of Capital1: " + capital1.Population);
        Console.WriteLine("Population of Capital2: " + capital2.Population);
        Console.WriteLine("Population of Capital3: " + capital3.Population);

        ICapital largestCapital;
        if (capital1.Population > capital2.Population && capital1.Population > capital3.Population)
        {
            largestCapital = capital1;
        }
        else if (capital2.Population > capital1.Population && capital2.Population > capital3.Population)
        {
            largestCapital = capital2;
        }
        else
        {
            largestCapital = capital3;
        }

        Console.WriteLine("The capital with the largest population is: " + largestCapital.Population);
    }
}

