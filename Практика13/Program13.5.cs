using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр13._5
{
    class Animal
    {
        public string Type { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public Animal(string type, int age, string habitat, string diet)
        {
            Type = type;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }
        public void Info()
        {
            Console.WriteLine($"Вид: {Type}, возраст: {Age} лет, среда обитания: {Habitat}, рацион: {Diet}");
        }
    }
    class Mammal : Animal
    {
        public string Fur { get; set; }
        public int Pregnancy { get; set; }
        public Mammal(string type, int age, string habitat, string diet, string fur, int pregnancy) : base(type, age, habitat, diet)
        {
            Fur = fur;
            Pregnancy = pregnancy;
        }
        public void Info()
        {
            base.Info();
            Console.WriteLine($"Тип меха: {Fur}, продолжительность беременности: {Pregnancy} месяца");
        }
    }
    class Bird : Animal
    {
        public int Wingspan { get; set; }
        public string Nesting { get; set; }
        public Bird(string type, int age, string habitat, string diet, int wingspan, string nesting) : base(type, age, habitat, diet)
        {
            Wingspan = wingspan;
            Nesting = nesting;
        }
        public void Info()
        {
            base.Info();
            Console.WriteLine($"Размах крыльев: {Wingspan} см, тип гнездования: {Nesting}");
        }
    }
    class Reptile : Animal
    {
        public string Skin { get; set; }
        public int Temp { get; set; }
        public Reptile(string type, int age, string habitat, string diet, string skin, int temp) : base(type, age, habitat, diet)
        {
            Skin = skin;
            Temp = temp;
        }
        public void Info() { base.Info(); Console.WriteLine($"Тип кожи: {Skin}, температура среды: {Temp}°C"); }
    }
    class Fish : Animal
    {
        public string Scales { get; set; }
        public int Depth { get; set; }
        public Fish(string type, int age, string habitat, string diet, string scales, int depth) : base(type, age, habitat, diet)
        {
            Scales = scales;
            Depth = depth;
        }
        public void Info() { base.Info(); Console.WriteLine($"Тип чешуи: {Scales}, глубина обитания: {Depth} м"); }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            var mammal = new Mammal("Панда ", 15, "Горные районы центрального Китая", "бамбук", " густой",150);
            var bird = new Bird("Пингвины", 15, "Южное полушарие", "Рыба, головоногие моллюски, медуза", 160, " из камней или в норах");
            var reptile = new Reptile("Хамелеон",5, " Тропические леса", "насекомые", "сложная многослойная", 30);
            var fish = new Fish("Рыбка кузовок", 8, "субтропические  воды", "морские ежи, морские звёзды, оболочники, крабы, голотурии, губки,", " отсутствует", 50);
            Console.WriteLine("Млекопитающие");
            mammal.Info();
            Console.WriteLine("Птица");
            bird.Info();
            Console.WriteLine("Рептилия");
            reptile.Info();
            Console.WriteLine("Рыба");
            fish.Info();
        }
    }
}
