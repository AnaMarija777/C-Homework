
using Homework6.Company;

Console.WriteLine("Homework 5");

Manager manager1 = new Manager("Sinisa", "Sinoski", "ESZ");
Manager manager2 = new Manager("Emil", "Nedelkovski", "EBR");

Employee[] company = new Employee[5]
{
    new Contractor("Jack","Jackov", 6,200, manager1),
    new Contractor("Ivo","Mishel",2,400, manager2),
    manager1,
    manager2,
    new SalesPerson("Ane", "Aleksov")
};

Ceo ceo = new Ceo("Ana Marija", "Stojchevska", company, 6000);
ceo.PrintInfo();
ceo.PrintEmployees();
ceo.GetSalary();



