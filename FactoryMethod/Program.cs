using System;

namespace FactoryMethod
{
    abstract class House { }

    class PanelHouse : House
    {
        public PanelHouse(string DevName)
        {
            Console.WriteLine($"Panel house built by {DevName}");
        }
    }
    class WoodenHouse : House
    {
        public WoodenHouse(string DevName)
        {
            Console.WriteLine($"Wooden house built by {DevName}");
        }
    }

    abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string Name) { this.Name = Name; }

        abstract public House Create(string DevName);
    }

    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string Name) : base(Name) { }

        public override House Create(string DevName)
        {
            return new PanelHouse(DevName);
        }
    }

    class WoodenDeveloper : Developer
    {
        public WoodenDeveloper (string Name) : base(Name) { }
        public override House Create(string DevName)
        {
            return new WoodenHouse(DevName);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Developer panelDeveloper = new PanelDeveloper("OOO PanelDeveloer");
            House panelHouse = panelDeveloper.Create(panelDeveloper.Name);

            Developer woodenDeveloper = new WoodenDeveloper("OOO WoodenDeveloper");
            House woodenHouse = woodenDeveloper.Create(woodenDeveloper.Name);

            Console.ReadKey();
        }
    }
}