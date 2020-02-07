using Control;
using Model.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace View
{
    class Program
    {
        public static String strConsoleTitle;
        public static int intHeight = 30;
        public static int intWidth = 90;
        public static int index = 0;
        public static int intLeft = 40; public static int intTop = 0;
        public static string strUserName, Username, Password, strPassword = string.Empty;
        public static string strZmco = "ZM Co";
        public static string strAppDesc = "Cette Application vous permet de créer un arbre géalogique";
        public static string strAppDesc2 = "Vous pourriez créer, ou modifier l'arbre";
        public static string strAppDesc3 = "Commencez par créer une personne";
        public static string strCopyRight = "CopyRight 2020 - ZM Co";
        public static string strAppTitle = "arbre géalogique";
        static void Main(string[] args)
        {
            IUnity tussen = new Switch().Bridge();
            var entities = tussen.Unities();
            var persons = tussen.Persons();
            var animals = tussen.Animals();
            //<<console
            AppConsole();
            //console>>
            #region true
            //int SelectedMenu = 6;
            //int CreatedMenu = 6;
            //int ShowedMenu = 6;
            //while (SelectedMenu != 0)
            //{
            //    Start();
            //    SelectedMenu = Action("Choose 0(Quit) - 1(Create) - 2(Inventory): ");

            //    switch (SelectedMenu)
            //    {
            //        case 0:
            //            Start();
            //            string byebye = "You are about Leaving...";
            //            Console.WriteLine(byebye + "\n" + "Press any key to quit...");
            //            Console.ReadKey();
            //            break;
            //        case 1:
            //            Start();
            //            string creating = "You are about Creating...";
            //            Console.WriteLine(creating);
            //            while (CreatedMenu != 0)
            //            {
            //                CreatedMenu = Action("Choose 0(Quit) - 1(Person) - 2(Animal): ");
            //                switch (CreatedMenu)
            //                {
            //                    case 1:
            //                        Console.Clear();
            //                        Start();
            //                        Console.WriteLine("You are about to Create a Person");
            //                        tussen.CreatePerson();
            //                        break;
            //                    case 2:
            //                        Console.Clear();
            //                        Start();
            //                        Console.WriteLine("You are about to Create an animal");
            //                        tussen.CreateAnimal();
            //                        break;
            //                    default:
            //                        break;
            //                }
            //            }
            //            break;
            //        case 2:
            //            Start();
            //            string reading = "You are about Reading...";
            //            Console.WriteLine(reading);
            //            while (ShowedMenu != 0)
            //            {
            //                ShowedMenu = Action("Choose 0(Quit) - 1(Person) - 2(Animal): - 3(All) ");
            //                switch (ShowedMenu)
            //                {
            //                    case 1:
            //                        Console.Clear();
            //                        Console.WriteLine(reading);
            //                        Console.WriteLine("You are about to Read Person");
            //                        Console.WriteLine("PERSONS");
            //                        foreach (var item in persons)
            //                        {
            //                            Console.WriteLine(item);
            //                        }
            //                        break;
            //                    case 2:
            //                        Console.Clear();
            //                        Console.WriteLine(reading);
            //                        Console.WriteLine("You are about to Read Animal");
            //                        Console.WriteLine("ANIMALS");
            //                        foreach (var item in animals)
            //                        {
            //                            Console.WriteLine(item);
            //                        }
            //                        break;
            //                    case 3:
            //                        Console.Clear();
            //                        Console.WriteLine(reading);
            //                        Console.WriteLine("You are about to Read All entities ()");
            //                        foreach (var item in entities)
            //                        {
            //                            Console.WriteLine(item);
            //                        }
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
            Console.ReadKey();
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
        public static void AppConsole()
        {
            strConsoleTitle = strZmco + " - " + strAppTitle.ToUpper();
            Console.SetBufferSize(120, 60);
            Console.SetWindowSize(intWidth, intHeight);
            Console.Title = strConsoleTitle;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            AppTitle();
            AppDesc();
            AppCopyRight();
            AppExec();
            //AppQuit();
        }
        static void AppTitleBg()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 1; i < 6; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(new string(' ', 86));
            }
        }
        static void AppTitle()
        {
            Console.SetBufferSize(120, 60);
            AppTitleBg();
            Console.SetCursorPosition((intWidth / 2) - (strAppTitle.Length / 2), 2);
            for (int i = 0; i < strAppTitle.Length + 4; i++)
            {
                Console.Write("#");
            }
            Console.SetCursorPosition((intWidth / 2) - (strAppTitle.Length / 2), 3);
            Console.WriteLine("# " + strAppTitle.ToUpper() + " #");
            Console.SetCursorPosition((intWidth / 2) - (strAppTitle.Length / 2), 4);
            for (int i = 0; i < strAppTitle.Length + 4; i++)
            {
                Console.Write("#");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
        }
        static void AppDescBg()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 7; i < 10; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(new string(' ', 86));
            }
            //Console.ResetColor();
        }
        public static void AppDesc()
        {
            AppDescBg();
            Console.SetCursorPosition((intWidth / 2) - (strAppDesc.Length / 2), 7);
            Console.Write(strAppDesc);
            Console.SetCursorPosition((intWidth / 2) - (strAppDesc2.Length / 2), 8);
            Console.Write(strAppDesc2);
            Console.SetCursorPosition((intWidth / 2) - (strAppDesc3.Length / 2), 9);
            Console.WriteLine(strAppDesc3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
        }
        public static void AppExec()
        {
            AppExecBg();
            List<string> menuItems = new List<string>() { "voir", "ajouter", "modifier", "exit" };

            Console.CursorVisible = false;

            while (true)
            {
                AppExecBg();
                AppTitle();
                AppDesc();
                AppCopyRight();
                Console.BackgroundColor = ConsoleColor.Blue;
                string strSelectedMenuItem = MyMenu(menuItems);
                Program.intLeft = 40; Program.intTop = 14;
                switch (strSelectedMenuItem)
                {
                    case "voir":
                        Menu.MenuVoir();
                        break;
                    case "ajouter":
                        Menu.MenuAjout();
                        break;
                    case "modifier":
                        Menu.MenuModifier();
                        break;
                    case "exit":
                        Menu.MenuExit();
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }
        static string MyMenu(List<string> items)
        {
            int intLeft = 12; int intTop = 11;
            Console.SetCursorPosition(intLeft, intTop);
            for (int i = 0; i < items.Count; i++)
            {
                List<string> menuItemsDescription = new List<string>() { "ici pour voir les taches à faire",
                "ici pour ajouter des taches","ici pour modifier ou supprimer les taches",
                "ici pour quitter l'application"};
                Console.SetCursorPosition(intLeft, intTop += 2);

                if (i == Program.index)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine((items[i]).ToUpper());
                    Console.SetCursorPosition(25, 17);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(menuItemsDescription[Program.index]);
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.WriteLine((items[i]).ToLower());
                }

            }
            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                AppExecBg();
                AppTitle();
                AppDesc();
                AppCopyRight();

                if (Program.index == items.Count - 1)
                {
                    Program.index = 0;
                }
                else
                {
                    Program.index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                AppExecBg();
                AppTitle();
                AppDesc();
                AppCopyRight();
                if (Program.index <= 0)
                {
                    Program.index = items.Count - 1;
                }
                else
                {
                    Program.index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[Program.index];
            }
            else
            {
                return "";
            }
            Console.Clear();
            return "";
        }
        class Menu
        {
            private const string Path = @"c:\Res\dailypurpose.txt";

            public static void MenuExit()
            {
                AppExecBgAll();
                for (int i = 11; i < 50; i += 15)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(40, 16);
                    Console.WriteLine("Bye Bye".ToUpper());
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(i, 18);
                    Console.WriteLine("U wordt uitgeschakeld. Please wait...");
                    Thread.Sleep(500);
                    AppExecBgAll();
                }
                Environment.Exit(0);
            }
            public static void AppExecBgAll()
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                for (int i = 11; i < 24; i++)
                {
                    Console.SetCursorPosition(10, i);
                    Console.Write(new string(' ', 69));
                }
            }
            public static void MenuAjout()
            {
                List<string> lstStrListeTaches = new List<string> { };
                AppExecBg();
                Console.SetCursorPosition(25, 16);
                string strTache = string.Empty;
                Console.Write("Combien de taches: ");
                Console.CursorVisible = true;
                int lstStrListeTaches_Longueur = int.Parse(Console.ReadLine());

                if (lstStrListeTaches_Longueur > 0 && lstStrListeTaches_Longueur < 4)
                {
                    for (int i = 1; i < lstStrListeTaches_Longueur + 1; i++)
                    {
                        AppExecBg();
                        AppTitle();
                        AppDesc();
                        AppCopyRight();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.CursorVisible = true;
                        Console.SetCursorPosition(25, 16);
                        Console.Write("{0}: Entrez votre tache: ", i);
                        strTache = Console.ReadLine();
                        lstStrListeTaches.Add(strTache);
                    }
                    using (StreamWriter sw = new StreamWriter(File.Create(Path)))
                    {
                        sw.Write(DateTime.Now.ToShortDateString() + " ");
                        for (int i = 0; i < lstStrListeTaches.Count; i++)
                        {
                            sw.Write(lstStrListeTaches[i] + " ");
                        }
                        sw.Close();
                    }
                    Console.SetCursorPosition(30, 18);
                    Console.WriteLine("Purpose registered. Please wait...");

                }
                else
                {
                    Console.SetCursorPosition(30, 18);

                    Console.WriteLine("Choose between 1 and 3");
                }

                Thread.Sleep(1500);
            }
            public static void MenuVoir()
            {
                AppExecBg();
                Console.SetCursorPosition(Program.intLeft - 15, 11 + 2);
                using (StreamReader sr = new StreamReader(File.Open(Path, FileMode.Open)))
                {
                    Console.WriteLine(sr.ReadLine());
                    sr.Close();
                    Thread.Sleep(3000);
                }
                Console.SetCursorPosition(Program.intLeft - 15, 21);

                Console.WriteLine("Press any key to quit...");
                Console.ReadKey();

            }
            public static void MenuModifier()
            {
                List<string> lstStrListeTaches = new List<string> { };
                AppExecBg();
                Console.SetCursorPosition(25, 16);
                string strTache = string.Empty;
                Console.CursorVisible = true;
                AppExecBg();
                AppTitle();
                AppDesc();
                AppCopyRight();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorVisible = true;
                Console.SetCursorPosition(25, 16);
                //Console.Write("{0}: Entrez votre tache: ", i);
                //strTache = Console.ReadLine();
                lstStrListeTaches.Add(" ");

                using (StreamWriter sw = new StreamWriter(File.Create(Path)))
                {
                    sw.Write(DateTime.Now.ToShortDateString() + " ");
                    for (int i = 0; i < lstStrListeTaches.Count; i++)
                    {
                        sw.Write(lstStrListeTaches[i] + " ");
                    }
                    sw.Close();
                }
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("Purpose deleted. Please wait...");
                Thread.Sleep(1500);
            }
        }
        public static void AppExecBg()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 11; i < 24; i++)
            {
                Console.SetCursorPosition(10, i);
                Console.Write(new string(' ', 69));
            }

            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 12; i < 23; i++)
            {
                Console.SetCursorPosition(11, i);
                Console.Write(new string(' ', 10));
            }

            Console.BackgroundColor = ConsoleColor.Green;
            for (int i = 12; i < 23; i++)
            {
                Console.SetCursorPosition(22, i);
                Console.Write(new string(' ', 56));
            }
        }
        public static void AppCopyRight()
        {
            AppCopyRightBg();

            Console.SetCursorPosition((Program.intWidth - Program.strCopyRight.Length) - 3, 27);
            Console.WriteLine(Program.strCopyRight + " ");

            Console.SetCursorPosition(2, 27);
            Console.Write(" " + DateTime.Now);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.CursorVisible = false;
        }
        static void AppCopyRightBg()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 26; i < 29; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write(new string(' ', 86));
            }
        }
        public static void AppQuit()
        {
            Console.SetCursorPosition(35, 24);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press any key to quit...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
