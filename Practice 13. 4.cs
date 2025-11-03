using System;

class Course
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Course(string title, string description, string author, double price)
    {
        Title = title;
        Description = description;
        Author = author;
        Price = price;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Описание: {Description}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Цена: {Price} руб.");
    }
}

class VideoCourse : Course
{
    public int VideoCount { get; set; }
    public double Duration { get; set; } // в часах

    public VideoCourse(string title, string description, string author, double price, int videoCount, double duration)
        : base(title, description, author, price)
    {
        VideoCount = videoCount;
        Duration = duration;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество видео: {VideoCount}");
        Console.WriteLine($"Общая длительность: {Duration} ч.");
        Console.WriteLine();
    }
}

class TextCourse : Course
{
    public int ChapterCount { get; set; }
    public int TextVolume { get; set; } // количество страниц или строк

    public TextCourse(string title, string description, string author, double price, int chapterCount, int textVolume)
        : base(title, description, author, price)
    {
        ChapterCount = chapterCount;
        TextVolume = textVolume;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество глав: {ChapterCount}");
        Console.WriteLine($"Объем текста: {TextVolume} страниц");
        Console.WriteLine();
    }
}

class InteractiveCourse : Course
{
    public int ExerciseCount { get; set; }
    public string CheckingSystem { get; set; }

    public InteractiveCourse(string title, string description, string author, double price, int exerciseCount, string checkingSystem)
        : base(title, description, author, price)
    {
        ExerciseCount = exerciseCount;
        CheckingSystem = checkingSystem;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество упражнений: {ExerciseCount}");
        Console.WriteLine($"Система проверки: {CheckingSystem}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        VideoCourse v = new VideoCourse("C# для начинающих", "Основы языка C#", "Иванов", 2500, 100, 24);
        TextCourse t = new TextCourse("Обретая свободу", "Текстовый курс с иллюстрациями", "Петрова", 1500, 20, 20);
        InteractiveCourse i = new InteractiveCourse("Английский онлайн", "Интерактивные упражнения", "Сидорова", 3000, 120, "Автоматическая проверка");

        v.ShowInfo();
        t.ShowInfo();
        i.ShowInfo();

        Console.ReadLine();
    }
}