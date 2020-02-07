using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading;

using System.Threading.Tasks;



namespace Model.Models

{

    public class MyConsole

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

        public static string strAppTitle = "arbre généalogique";

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

        public static void AppTitleBg()

        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.BackgroundColor = ConsoleColor.White;

            for (int i = 1; i < 6; i++)

            {

                Console.SetCursorPosition(2, i);

                Console.Write(new string(' ', 86));

            }

        }

        public static void AppTitle()

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

        public static void AppDescBg()

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



            Console.SetCursorPosition((intWidth - strCopyRight.Length) - 3, 27);

            Console.WriteLine(strCopyRight + " ");



            Console.SetCursorPosition(2, 27);

            Console.Write(" " + DateTime.Now);



            Console.ForegroundColor = ConsoleColor.White;

            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Console.CursorVisible = false;

        }

        public static void AppCopyRightBg()

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

        public MyConsole()

        {

            AppConsole();

        }

    }



}