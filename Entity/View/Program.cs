using Control;
using Model.Models;
using System;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnity tussen = new Switch().Bridge();
            var entities = tussen.Unities();
            var persons = tussen.Persons();
            var animals = tussen.Animals();
            #region true
            int SelectedMenu = 6;
            int CreatedMenu = 6;
            int ShowedMenu = 6;
            while (SelectedMenu != 0)
            {
                Start();
                SelectedMenu = Action("Choose 0(Quit) - 1(Create) - 2(Inventory): ");

                switch (SelectedMenu)
                {
                    case 0:
                        Start();
                        string byebye = "You are about Leaving...";
                        Console.WriteLine(byebye + "\n" + "Press any key to quit...");
                        Console.ReadKey();
                        break;
                    case 1:
                        Start();
                        string creating = "You are about Creating...";
                        Console.WriteLine(creating);
                        while (CreatedMenu != 0)
                        {
                            CreatedMenu = Action("Choose 0(Quit) - 1(Person) - 2(Animal): ");
                            switch (CreatedMenu)
                            {
                                case 1:
                                    Console.Clear();
                                    Start();
                                    Console.WriteLine("You are about to Create a Person");
                                    tussen.CreatePerson();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Start();
                                    Console.WriteLine("You are about to Create an animal");
                                    tussen.CreateAnimal();
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Start();
                        string reading = "You are about Reading...";
                        Console.WriteLine(reading);
                        while (ShowedMenu != 0)
                        {
                            ShowedMenu = Action("Choose 0(Quit) - 1(Person) - 2(Animal): - 3(All) ");
                            switch (ShowedMenu)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(reading);
                                    Console.WriteLine("You are about to Read Person");
                                    Console.WriteLine("PERSONS");
                                    foreach (var item in persons)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(reading);
                                    Console.WriteLine("You are about to Read Animal");
                                    Console.WriteLine("ANIMALS");
                                    foreach (var item in animals)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(reading);
                                    Console.WriteLine("You are about to Read All entities ()");
                                    foreach (var item in entities)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("break bye");
                        break;
                }
            }
            #endregion
        }
        private static int Action(string message)
        {
            int action;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out action))
            {
                Console.Clear();
                Console.Write(message);
            }
            return action;
        }
        private static void Start()
        {
            string start = "Start Administration";

            Console.Clear();
            Console.WriteLine(start);
        }
    }
}
