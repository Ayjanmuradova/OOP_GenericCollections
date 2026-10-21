namespace OOP_GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create five Employee objects
            Employee emp1 = new Employee() { Id = 101, Name = "Anas", Gender="Male", Salary = 20000};
            Employee emp2 = new Employee() { Id = 102, Name = "Hanna", Gender = "Female", Salary = 30000 };
            Employee emp3 = new Employee() { Id = 103, Name = "Tobias", Gender = "Male", Salary = 40000 };
            Employee emp4 = new Employee() { Id = 104, Name = "Sara", Gender = "Female", Salary = 40000 };
            Employee emp5 = new Employee() { Id = 105, Name = "Anna", Gender = "Female", Salary = 50000 };

            // Create a stack and add the objects using Push()
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);

            // Print all objects with foreach (does not remove anything from the stack)
            foreach (Employee employee in stack)
            {
                Console.WriteLine( $"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine("Items left in the Stack = " + stack.Count);   
            }

            Console.WriteLine( "------------------------------------------");
            Console.WriteLine( "Retrive Using Pop Method");

            // Pop removes and returns the top item, so the count decreases each time
                while (stack.Count > 0)
            {
                Employee poppedEmp = stack.Pop();
                Console.WriteLine( $"{poppedEmp.Id} - {poppedEmp.Name} - {poppedEmp.Gender} - {poppedEmp.Salary}");
                Console.WriteLine("Items left in the Stack = " + stack.Count);
            }

            // Add all objects back in the same order (101 to 105) so 105 ends up on top
            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);
            stack.Push(emp5);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Retrive Using Peek Method");

            // Peek returns the top item without removing it, so the count stays the same
            Employee peekedEmp1 = stack.Peek();
            Console.WriteLine( $"{peekedEmp1.Id} - {peekedEmp1.Name} - {peekedEmp1.Gender} - {peekedEmp1.Salary}");
            Console.WriteLine("Items left in the Stack = " + stack.Count);

            Employee peekedEmp2 = stack.Peek();
            Console.WriteLine($"{peekedEmp2.Id} - {peekedEmp2.Name} - {peekedEmp2.Gender} - {peekedEmp2.Salary}");
            Console.WriteLine("Items left in the Stack = " + stack.Count);

            Console.WriteLine("------------------------------------------");

            if (stack.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in stack");  
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }

            
            Console.WriteLine("------------------------------------------");

            // Create a list and add the five objects
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            employeeList.Add(emp4);
            employeeList.Add(emp5);

            // Check if Employee2 exists in the list using Contains()
            if (employeeList.Contains(emp2))
            {
                Console.WriteLine("Employee2 object exists in the list"); 
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }
            Console.WriteLine();

            // Find returns the first employee whose Gender is "Male"
            Employee genderMale = employeeList.Find(emp => emp.Gender == "Male");
            Console.WriteLine($"ID = {genderMale.Id}, Name = {genderMale.Name}, Gender = {genderMale.Gender}, Salary = {genderMale.Salary}");
            Console.WriteLine();

            // FindAll returns every employee whose Gender is "Male"
            List<Employee> allMales = employeeList.FindAll(emp => emp.Gender == "Male");
            foreach (Employee male in allMales)
            {
                Console.WriteLine($"ID = {male.Id}, Name = {male.Name}, Gender = {male.Gender}, Salary = {male.Salary}");
                
            }

        }
    }
}
