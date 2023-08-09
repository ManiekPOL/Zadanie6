

using Zadanie6;

Employee Employee1 = new Employee("Marek", "Nowak", 50);
Employee Employee2 = new Employee("Jan", "Kochanowski", 27);
Employee Employee3 = new Employee("Łukasz", "Kowalski", 57);

Employee1.AddScore(9);
Employee1.AddScore(9);
Employee1.AddScore(9);
Employee1.AddScore(9);
Employee1.AddScore(9);

Employee2.AddScore(4);
Employee2.AddScore(5);
Employee2.AddScore(6);
Employee2.AddScore(7);
Employee2.AddScore(8);

Employee3.AddScore(5);
Employee3.AddScore(6);
Employee3.AddScore(7);
Employee3.AddScore(8);
Employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    Employee1, Employee2, Employee3
};
int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }
}
Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " lat " +
employeeWithMaxResult.Age + ", Zdobył " + employeeWithMaxResult.Result + " punktów.");

