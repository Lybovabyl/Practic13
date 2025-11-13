using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр13._33
{
    class LibraryItem
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Status { get; set; }
        public LibraryItem(string name, string author, int year, string status)
        {
            Name = name;
            Author = author;
            Year = year;
            Status = status;
        }
        public void Info()
        {
            Console.WriteLine($"Название книги: {Name}, Автор: {Author}, год издания: {Year}, статус доступности: {Status}");
        }
    }
    class Book : LibraryItem
    {
        public int Quantity { get; set; }
        public long ISBN { get; set; }
        public Book(string name, string author, int year, string status, int quantity, long isbn) : base("", "", year, status)
        {
            Quantity = quantity;
            ISBN = isbn;
        }
        public void Info1() { Console.WriteLine($"Количество страниц: {Quantity}, ISBN  {ISBN}"); }
    }
    class Magazine : LibraryItem
    {
        public int Numder { get; set; }
        public double Period { get; set; }
        public Magazine(string name, string author, int year, string status, int numder, double period) : base("", "", year, status)
        {
            Numder = numder;
            Period = period;
        }
        public void Info2() { Console.WriteLine($"Номер выпуска: {Numder}, периодичность: {Period}"); }
    }
    class DVD : LibraryItem
    {
        public double Duration { get; set; }
        public double Rating { get; set; }
        public DVD(string name, string author, int year, string status, double duration, double rating) : base("", "", year, status)
        {
            Duration = duration;
            Rating = rating;
        }
        public void Info3()
        {
            Console.WriteLine($"Продолжительность: {Duration}, рейтинг: {Rating}");
        }

    }
    class Audiobook : LibraryItem
    {
        public double Durat { get; set; }
        public string Speaker { get; set; }
        public Audiobook(string name, string author, int year, string status, double durat, string speaker) : base("", "", year, status)
        {
            Durat = durat;
            Speaker = speaker;
        }
        public void Info4() { Console.WriteLine($"Длительность: {Durat}, диктор: {Speaker}"); }

        static void Main(string[] args)
        {
            LibraryItem libraryItem = new LibraryItem("Скорбь Сатаны", "Мария Корелли", 2025, "доступен");
            libraryItem.Info();
            Book book = new Book("Скорбь Сатаны", "Мария Корелли", 2025, "доступен", 512, 978-5-04-208245-0);
            book.Info1();
            Magazine magazine = new Magazine("Скорбь Сатаны", "Мария Корелли", 2025, "доступен", 7, 02.40);
            magazine.Info2();
            DVD dVD = new DVD("Скорбь Сатаны", "Мария Корелли", 2025, "доступен", 1.10, 4.2);
            dVD.Info3();
            Audiobook audiobook = new Audiobook("Скорбь Сатаны", "Мария Корелли", 2025, "доступен",17.1, "Никита Полицеймако");
            audiobook.Info4();
        }
    }
}
    

