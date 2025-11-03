using System;

class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }

    public Employee(string name, string position, decimal salary, DateTime hireDate)
    {
        Name = name;
        Position = position;
        Salary = salary;
        HireDate = hireDate;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{Position} {Name}, зарплата: {Salary}, принят: {HireDate.ToShortDateString()}");
    }
}

class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, decimal salary, DateTime hireDate, int teamSize)
        : base(name, "Менеджер", salary, hireDate)
    {
        TeamSize = teamSize;
    }

    public void HoldMeeting()
    {
        Console.WriteLine($"{Name} проводит собрание для команды из {TeamSize} человек.");
    }
}

class Developer : Employee
{
    public string Language { get; set; }

    public Developer(string name, decimal salary, DateTime hireDate, string language)
        : base(name, "Разработчик", salary, hireDate)
    {
        Language = language;
    }

    public void WriteCode()
    {
        Console.WriteLine($"{Name} пишет код на {Language}.");
    }
}

class Director : Employee
{
    public string Department { get; set; }

    public Director(string name, decimal salary, DateTime hireDate, string department)
        : base(name, "Директор", salary, hireDate)
    {
        Department = department;
    }

    public void ApproveBudget()
    {
        Console.WriteLine($"{Name} утвердил бюджет отдела {Department}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager m = new Manager("Иван", 80000, DateTime.Now, 5);
        Developer d = new Developer("Ольга", 90000, DateTime.Now, "C#");
        Director dir = new Director("Анна", 150000, DateTime.Now, "IT");

        m.ShowInfo();
        m.HoldMeeting();

        d.ShowInfo();
        d.WriteCode();

        dir.ShowInfo();
        dir.ApproveBudget();

        Console.ReadLine();
    }
}