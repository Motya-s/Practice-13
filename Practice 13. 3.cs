using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    //БАЗОВЫЙ КЛАСС
    class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool Free { get; set; }

        public LibraryItem(string title, string author, int year, bool free)
        {
            Title = title;
            Author = author;
            Year = year;
            Free = free;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Год: {Year}, Доступна: {Free}");
        }
    }

    //КЛАСС КНИГА
    class Book : LibraryItem
    {
        public int Pages { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, int year, bool free, int pages, string isbn)
            : base(title, author, year, free)
        {
            Pages = pages;
            ISBN = isbn;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Страниц: {Pages}, ISBN: {ISBN}");
        }
    }

    //КЛАСС ЖУРНАЛ 
    class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string Frequency { get; set; }

        public Magazine(string title, string author, int year, bool free, int issueNumber, string frequency)
            : base(title, author, year, free)
        {
            IssueNumber = issueNumber;
            Frequency = frequency;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Выпуск {IssueNumber}, Периодичность: {Frequency}");
        }
    }

    // ====== КЛАСС DVD ======
    class DVD : LibraryItem
    {
        public int Duration { get; set; }
        public string Rating { get; set; }

        public DVD(string title, string author, int year, bool free, int duration, string rating)
            : base(title, author, year, free)
        {
            Duration = duration;
            Rating = rating;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Длительность: {Duration} мин, Рейтинг: {Rating}");
        }
    }

    // ====== КЛАСС АУДИОКНИГА ======
    class Audiobook : LibraryItem
    {
        public int Length { get; set; }
        public string Narrator { get; set; }

        public Audiobook(string title, string author, int year, bool free, int length, string narrator)
            : base(title, author, year, free)
        {
            Length = length;
            Narrator = narrator;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Длительность: {Length} мин, Диктор: {Narrator}");
        }
    }

    // ====== ОСНОВНАЯ ПРОГРАММА ======
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём список материалов
            List<LibraryItem> items = new List<LibraryItem>
            {
                new Book("Война и мир", "Толстой", 1869, true, 1225, "978-5-389-02027-2"),
                new Magazine("Комсомольская правда", "Редакция", 1925, true, 20, "ежемесячно"),
                new DVD("Гарри Поттер и философский камень", "Джоан Роулинг", 2001, true, 152, "8,3"),
                new Audiobook("1984", "Джордж Оруэлл", 2020, true, 600, "Сергей Чонишвили")
            };

            foreach (var item in items)
            {
                item.ShowInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}