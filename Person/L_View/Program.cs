using L_Control;
using System;


namespace L_View
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson ipa = new Switch().Bridge();
            var managers = ipa.InventoryManager();
            var employees = ipa.InventoryEmployee();
            var persons = ipa.InventoryPerson();
            var entities = ipa.InventoryEntity();
            int SelectedMenu = 6;
            int CreatedMenu = 6;
            int ShowedMenu = 6;
            while (SelectedMenu!=0)
            {
                Console.Clear();
                SelectedMenu = GetIntputDecimal("Choose 0(Quit) - 1(Create) - 2(Inventory): ");
                switch (SelectedMenu)
                {
                    case 0:
                        Console.WriteLine("bye bye");
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You are about Creating...");
                        while (CreatedMenu!=0)
                        {
                            CreatedMenu = GetIntputDecimal("Choose 0(Quit) - 1(Entity) - 2(Manager): ");
                            switch (CreatedMenu)
                            {
                                case 1:
                                    Console.WriteLine("You are about to Create Entity");
                                    ipa.CreateEntity();
                                    Console.Clear();
                                    Console.WriteLine("ENTITIES");
                                    entities.Sort();
                                    foreach (var item in entities)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine("---");
                                    break;
                                case 2:
                                    Console.WriteLine("You are about to Create Manager");
                                    ipa.CreateManager();
                                    Console.Clear();
                                    Console.WriteLine("MANAGERS");
                                    managers.Sort();
                                    foreach (var item in managers)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine("---");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        while (ShowedMenu != 0)
                        {
                            ShowedMenu = GetIntputDecimal("Choose 0(Quit) - 1(Entity) - 2(Manager): - 3(All) ");
                            switch (ShowedMenu)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("You are about to Read Person");
                                    Console.WriteLine("ENTITIES");
                                    entities.Sort();
                                    foreach (var item in entities)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine("---");
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("You are about to Read Manager");
                                    Console.WriteLine("MANAGERS");
                                    managers.Sort();
                                    foreach (var item in managers)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine("---");
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("You are about to Read All entities ()");
                                    Console.WriteLine("ENTITIES");
                                    entities.Sort();
                                    foreach (var item in entities)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine("---");
                                    Console.WriteLine("MANAGERS");
                                    managers.Sort();
                                    foreach (var item in managers)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    Console.WriteLine("---");
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
        }
            private static int GetIntputDecimal(string message)
            {
                int number;
                Console.Write(message);
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Clear();
                    Console.Write(message);
                }
                return number;
            }
    }
} 
