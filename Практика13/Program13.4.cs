using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр13._4
{
    class Course
    {
        public string Title;
        public string Description;
        public string Author;
        public decimal Price;

        public Course(string title, string description, string author, decimal price)
        {
            Title = title;
            Description = description;
            Author = author;
            Price = price;
        }

        //информация о курсе
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Курс: {Title}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Цена: {Price} рублей");
        }

        //записаться на курс
        public virtual void Enroll()
        {
            Console.WriteLine($"Вы записались на курс {Title}");
        }
    }

    //наследие
    class VideoCourse : Course
    {
        public int VideoCount;
        public double TotalDuration; //в часах

        public VideoCourse(string title, string description, string author, decimal price, int videoCount, double totalDuration)
            : base(title, description, author, price)
        {
            VideoCount = videoCount;
            TotalDuration = totalDuration;
        }

        //просмотр информации
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Видео: {VideoCount} штук, общая длительность: {TotalDuration} часов.");
        }

        //просмотр видео
        public void WatchVideo()
        {
            Console.WriteLine("Просмотр видео....");
        }
    }

    //наследие
    class TextCourse : Course
    {
        public int ChapterCount;
        public int TotalTextSize;

        public TextCourse(string title, string description, string author, decimal price, int chapterCount, int totalTextSize)
            : base(title, description, author, price)
        {
            ChapterCount = chapterCount;
            TotalTextSize = totalTextSize;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Глав: {ChapterCount}, объем текста: {TotalTextSize} страниц");
        }

        public void ReadChapter()
        {
            Console.WriteLine("Чтение главы....");
        }
    }

    //наследие
    class InteractiveCourse : Course
    {
        public int ExerciseCount;
        public string CheckingSystem;

        public InteractiveCourse(string title, string description, string author, decimal price, int exerciseCount, string checkingSystem)
            : base(title, description, author, price)
        {
            ExerciseCount = exerciseCount;
            CheckingSystem = checkingSystem;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Упражнений: {ExerciseCount}, система проверки: {CheckingSystem}");
        }

        public void CompleteExercise()
        {
            Console.WriteLine("Выполнение упражнения...");
        }
    }

    class Program
    {
        static void Main()
        {

            VideoCourse video = new VideoCourse("PRO C#.", " C# Для продвинутых", "Иосиф Дзеранов",5650,60, 30);
            TextCourse text = new TextCourse("Веб-дизайнер", "Обучение веб-дизайну для начинающих", " Академия Синергия",1000,37, 712);
            InteractiveCourse interactive = new InteractiveCourse("курс как сделать лабубу", "Интерактивный курс", "трумтрум", 3000, 1, "Автоматическая проверка");


            video.ShowInfo();
            Console.WriteLine();
            text.ShowInfo();
            Console.WriteLine();
            interactive.ShowInfo();
            Console.WriteLine();

            
            video.Enroll();
            text.Enroll();
            interactive.Enroll();
        }
    }
}