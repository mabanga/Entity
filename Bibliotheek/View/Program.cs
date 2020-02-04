using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            #region true
            int SelectedMenu = -1;
            int LidMenu = -1;
            int MedewerkerMenu = -1;
            while (SelectedMenu != 0)
            {
                Start();
                SelectedMenu = Action("Choose 0(Quit) - 1(Bezoeker) - 2(InLoggen): ");

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
                        string bezoek = "You are about Bezoek Logging...";
                        Console.WriteLine(bezoek);
                        while (LidMenu != 0)
                        {
                            LidMenu = Action("Choose 0(Overzicht) - 1(As Lid) - 2(Item Zoeken): ");
                            switch (LidMenu)
                            {
                                case 0:
                                    Start();
                                    string overzicht = "You are about to go Overzicht...";
                                    Console.WriteLine(overzicht + "\n" + "Press any key to go back...");
                                    Console.ReadKey();
                                    break;
                                case 1:
                                    Console.Clear();
                                    Start();
                                    Console.WriteLine("You are about to Become Lid");
                                    Console.WriteLine("Press any key to go back...");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Start();
                                    Console.WriteLine("You are about to Search item");
                                    Console.WriteLine("Press any key to go back...");
                                    Console.ReadKey();

                                    break;
                                default:
                                    break;
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Start();
                        string reading = "You are about LoggingAdmin...";
                        Console.WriteLine(reading);
                        while (MedewerkerMenu != 0)
                        {
                            MedewerkerMenu = Action("Choose 0(Quit) - 1(Lid) - 2(Medewerker): ");
                            switch (MedewerkerMenu)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(reading);
                                    Console.WriteLine("You are about to Log As Lid");
                                    Console.WriteLine("Press any key to go back...");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(reading);
                                    Console.WriteLine("You are about to Log As Medewerker");
                                    Console.WriteLine("Press any key to go back...");
                                    Console.ReadKey();
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
                Console.SetCursorPosition(20, 0);

                Console.Write(message);
            }
            return action;
        }
        private static void Start()
        {
            string start = "Bibliotheek Boeken";
            Console.Clear();
            Console.SetCursorPosition(20, 0);
            Console.WriteLine(start);
        }
    }
}
