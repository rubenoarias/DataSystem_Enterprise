
using System;

namespace EmployeeData
{
    struct Employee
    {
        public string name;
        public int age;
        public double salary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];
            double lowestSalary = double.MaxValue;
            int count = 0;
            double totalSalary = 0;

            Console.WriteLine("Enter the data of 10 employees:");
            Console.WriteLine();

            // Loop through the array to read in the data of each employee/ Recorra la matriz para leer los datos de cada empleado
            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write($"Employee {i + 1} name: ");
                employees[i].name = Console.ReadLine();

                Console.Write($"Employee {i + 1} age: ");
                employees[i].age = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Employee {i + 1} salary: ");
                employees[i].salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
            }

            // Loop through the array to find the lowest-paid employee/ Recorra la matriz para encontrar al empleado peor pagado
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].salary < lowestSalary)
                {
                    lowestSalary = employees[i].salary;
                }
            }

            Console.WriteLine($"Data of the lowest-paid employee:");

            // Loop through the array to display the data of the lowest-paid employee(s)/ Recorra la matriz para mostrar los datos de los empleados peor pagados
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].salary == lowestSalary)
                {
                    Console.WriteLine($"Name: {employees[i].name}");
                    Console.WriteLine($"Age: {employees[i].age}");
                    Console.WriteLine($"Salary: {employees[i].salary}");
                    Console.WriteLine();
                }
            }

            // Loop through the array to calculate the average salary of employees between 20 and 30 years old/ Recorra la matriz para calcular el salario promedio de los empleados entre 20 y 30 años
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].age >= 20 && employees[i].age <= 30)
                {
                    totalSalary += employees[i].salary;
                    count++;
                }
            }

            double averageSalary = totalSalary / count;
            Console.WriteLine($"The average salary of employees between 20 and 30 years old is {averageSalary}");

            Console.ReadKey();
        }
    }
}

