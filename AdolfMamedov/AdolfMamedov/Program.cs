using System;

class Employee
{
    public string FIO { get; set; }
    public string OBRAZOVANIE { get; set; }
    public string DOLZHNOST { get; set; }
    public double OKLAD { get; set; }

    public Employee(string fullName, string education, string position, double salary)
    {
        FIO = fullName;
        OBRAZOVANIE = education;
        DOLZHNOST = position;
        OKLAD = salary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Информация о сотруднике:");
        Console.WriteLine("ФИО: " + FIO);
        Console.WriteLine("Образование: " + OBRAZOVANIE);
        Console.WriteLine("Должность: " + DOLZHNOST);
        Console.WriteLine("Оклад: " + OKLAD);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee("Гусейн Мамедов Сигмович", "Отсутствует", "По горшкам дежурный", 5000000.00);
        employee1.DisplayInfo();

        Employee employee2 = new Employee("Вадим Жуков Футболистович", "Среднее", "Футболист", 13000000.00);
        employee2.DisplayInfo();
    }
}