using System;

class Animal
{
    public string Species { get; set; }
    public int Age { get; set; }
    public string Obitaet { get; set; }
    public string Diet { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Вид: {Species}, Возраст: {Age}, Среда обитания: {Obitaet}, Рацион: {Diet}");
    }
}

//Млекопитающие
class Mammal : Animal
{
    public string FurType { get; set; }
    public int PregnancyDuration { get; set; }

    public void ShowMammalInfo()
    {
        Console.WriteLine($"Тип меха: {FurType}, Продолжительность беременности: {PregnancyDuration} месяцев\n");
    }
}

//Птицы 
class Bird : Animal
{
    public double Wingspan { get; set; }
    public string NestingType { get; set; }

    public void ShowBirdInfo()
    {
        Console.WriteLine($"Размах крыльев: {Wingspan} м, Тип гнездования: {NestingType}\n");
    }
}

//Рептилии
class Reptile : Animal
{
    public string SkinType { get; set; }
    public double PreferredTemperature { get; set; }

    public void ShowReptileInfo()
    {
        Console.WriteLine($"Тип кожи: {SkinType}, Температура среды: {PreferredTemperature} °C\n");
    }
}

//Рыбы
class Fish : Animal
{
    public string ScaleType { get; set; }
    public int Depth { get; set; }

    public void ShowFishInfo()
    {
        Console.WriteLine($"Тип чешуи: {ScaleType}, Глубина обитания: {Depth} м\n");
    }
}

//Главный метод
class Program
{
    static void Main(string[] args)
    {
        Mammal lion = new Mammal
        {
            Species = "Лев",
            Age = 3,
            Obitaet = "Саванна",
            Diet = "Плотоядный",
            FurType = "Короткий",
            PregnancyDuration = 4
        };

        Bird eagle = new Bird
        {
            Species = "Орел",
            Age = 2,
            Obitaet = "Горы",
            Diet = "Хищник",
            Wingspan = 2.3,
            NestingType = "Скалы"
        };

        Reptile snake = new Reptile
        {
            Species = "Алигатор",
            Age = 4,
            Obitaet = "Водоём",
            Diet = "Плотоядный",
            SkinType = "Чешуйчатая",
            PreferredTemperature = 30.5
        };

        Fish shark = new Fish
        {
            Species = "Акула",
            Age = 7,
            Obitaet = "Океан",
            Diet = "Хищник",
            ScaleType = "Плакоидная",
            Depth = 200
        };

        lion.ShowInfo();
        lion.ShowMammalInfo();

        eagle.ShowInfo();
        eagle.ShowBirdInfo();

        snake.ShowInfo();
        snake.ShowReptileInfo();

        shark.ShowInfo();
        shark.ShowFishInfo();

        Console.ReadLine();
    }
}