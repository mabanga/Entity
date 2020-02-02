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
            var persons = tussen.Persons();
            var animals = tussen.Animals();
            tussen.CreatePerson();
            #region true
            //int SelectedMenu = 6;
            //int CreatedMenu = 6;
            //int ShowedMenu = 6;
            //while (SelectedMenu != 0)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Start Administration");
            //    SelectedMenu = Action("Choose 0(Quit) - 1(Create) - 2(Inventory): ");
            //    switch (SelectedMenu)
            //    {
            //        case 0:
            //            Console.Clear();
            //            string byebye = "You are about Leaving...";
            //            Console.WriteLine(byebye+ "\n" +"Press any key to quit...");
            //            Console.ReadKey();
            //            break;
            //        case 1:
            //            Console.Clear();
            //            string creating = "You are about Creating...";
            //            Console.WriteLine(creating);
            //            while (CreatedMenu != 0)
            //            {
            //                CreatedMenu = Action("Choose 0(Quit) - 1(Entity) - 2(Manager): ");
            //                switch (CreatedMenu)
            //                {
            //                    case 1:
            //                        Console.Clear();
            //                        Console.WriteLine(creating);
            //                        Console.WriteLine("You are about to Create Entity");
            //                        break;
            //                    case 2:
            //                        Console.Clear();
            //                        Console.WriteLine(creating);
            //                        Console.WriteLine("You are about to Create Manager");
            //                        break;
            //                    default:
            //                        break;
            //                }
            //            }
            //            break;
            //        case 2:
            //            Console.Clear();
            //            string reading = "You are about Reading...";
            //            Console.WriteLine(reading);
            //            while (ShowedMenu != 0)
            //            {
            //                ShowedMenu = Action("Choose 0(Quit) - 1(Entity) - 2(Manager): - 3(All) ");
            //                switch (ShowedMenu)
            //                {
            //                    case 1:
            //                        Console.Clear();
            //                        Console.WriteLine(reading);
            //                        Console.WriteLine("You are about to Read Person");
            //                        Console.WriteLine("ENTITIES");
            //                        break;
            //                    case 2:
            //                        Console.Clear();
            //                        Console.WriteLine(reading);
            //                        Console.WriteLine("You are about to Read Manager");
            //                        Console.WriteLine("MANAGERS");
            //                        break;
            //                    case 3:
            //                        Console.Clear();
            //                        Console.WriteLine(reading);
            //                        Console.WriteLine("You are about to Read All entities ()");
            //                        Console.WriteLine("ENTITIES");
            //                        Console.WriteLine("---");
            //                        Console.WriteLine("MANAGERS");
            //                        Console.WriteLine("---");
            //                        break;
            //                    default:
            //                        break;
            //                }
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("break bye");
            //            break;
            //    }
            //}
            #endregion

            Person p = new Person("eric");
            Console.WriteLine(p);

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
    }
}
