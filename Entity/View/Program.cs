
using Control;

using Model.Models;

using System;

using System.Collections.Generic;

using System.IO;

using System.Threading;



namespace View

{

    public class Program

    {

        private static int index = 0;

        static void Main(string[] args)

        {

            IUnity tussen = new Switch().Bridge();

            var entities = tussen.Unities();

            var persons = tussen.Persons();

            var animals = tussen.Animals();

            //<<console

            MyConsole myConsole = new MyConsole();

            //console>>

            AppExec();



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

        static void Create()

        {

            IUnity tussen = new Switch().Bridge();

            var entities = tussen.Unities();

            var persons = tussen.Persons();

            var animals = tussen.Animals();

            int CreatedMenu = -1;

            Console.SetCursorPosition(35, 12);



            string creating = "You are about Creating...";

            Console.WriteLine(creating);

            while (CreatedMenu != 0)

            {

                Console.SetCursorPosition(30, 13);



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

        static void AppExec()

        {

            AppExecBg();

            List<string> menuItems = new List<string>() { "create", "read", "update", "delete", "exit" };



        }

        public static string MyMenu(List<string> items)

        {

            Console.Clear();

            MyConsole myConsole = new MyConsole();



            int index = 0;

            int intLeft = 12; int intTop = 11;

            Console.SetCursorPosition(intLeft, intTop);

            for (int i = 0; i < items.Count; i++)

            {

                List<string> menuItemsDescription = new List<string>() { "You are about to CREATE",

                "You are about to READ","You are about to UPDATE","You are about to DELETE",

                "You are about to QUIT"};

                Console.SetCursorPosition(intLeft, intTop += 2);

                Console.ResetColor();

                if (i == index)

                {

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.BackgroundColor = ConsoleColor.Blue;

                    //Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine((items[i]).ToUpper());

                    Console.SetCursorPosition(25, 17);

                    //Console.BackgroundColor = ConsoleColor.Blue;

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.BackgroundColor = ConsoleColor.Green;

                    Console.WriteLine(menuItemsDescription[index]);

                }

                else

                {

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.BackgroundColor = ConsoleColor.Blue;

                    Console.WriteLine((items[i]).ToLower());

                }



            }

            ConsoleKeyInfo ckey = Console.ReadKey();



            if (ckey.Key == ConsoleKey.DownArrow)

            {





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

                //AppExecBg();

                //AppTitle();

                //AppDesc();

                //AppCopyRight();

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



            public static void MenuDelete()

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

            public static void MenuRead()

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

                        //AppTitle();

                        //AppDesc();

                        //AppCopyRight();

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

            public static void MenuCreate()

            {

                AppExecBg();

                //Console.SetCursorPosition(35, 12);

                //using (StreamReader sr = new StreamReader(File.Open(Path, FileMode.Open)))

                //{

                //    Console.WriteLine(sr.ReadLine());

                //    sr.Close();

                //    Thread.Sleep(3000);

                //}

                //AppConsole();

                Create();

                //Console.SetCursorPosition(Program.intLeft - 15, 21);









                //AppConsole();



                Console.WriteLine("Press any key to quit...");

                Console.ReadKey();



            }

            public static void MenuUpdate()

            {

                List<string> lstStrListeTaches = new List<string> { };

                AppExecBg();

                Console.SetCursorPosition(25, 16);

                string strTache = string.Empty;

                Console.CursorVisible = true;

                AppExecBg();

                //AppTitle();

                //AppDesc();

                //AppCopyRight();

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

    }

}