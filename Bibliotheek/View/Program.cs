using Model;
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
            Bezoeker bezoeker = new Bezoeker();
            bezoeker.FamilieNaam = "FamBezoeker";
            bezoeker.VoorNaam = "VoorBezoeker";
            Console.WriteLine($"Bezoeker: {bezoeker}");
            Medewerker medewerker = new Medewerker();
            medewerker.FamilieNaam = "FamMedewerker";
            medewerker.VoegItemToe();

            //Item item = new Item();
            //item.Titel = "Petit bateau";
            Console.ReadLine();
            Console.WriteLine(" ");
            int? SelectedMenu = -1;
            do
            {
                Console.Clear();

                string str = "Please, choose an option to Log into Bibliothhek";
                //Start();
                Console.SetCursorPosition(20, 0);

                SelectedMenu = Action(str + "\n0(Quit) \n1(Bezoeker) \n2(Lid) \n3(Medewerker) \n");

                switch (SelectedMenu)
                {
                    case 0:
                        Start("You are about Leaving...");
                        Console.WriteLine("Press any key to quit...");
                        Console.ReadKey();
                        break;
                    case 1:
                        //Menu Bezoek
                        Case1();
                        break;
                    case 2:
                        //Menu Lid
                        Case2();
                        break;
                    case 3:
                        //Menu Medewerker
                        Case3();
                        break;
                    default:
                        Console.WriteLine("break bye");
                        break;
                }
            } while (SelectedMenu != 0 );
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
        private static void Start(string s)
        {
            string start = "Bibliotheek Boeken";
            Console.Clear();
            Console.SetCursorPosition(20, 0);
            Console.WriteLine(start);
            Console.WriteLine(s);
        }
        private static void Case1() //Menu Bezoek
        {
            int BezoekMenu = -1;

            while (BezoekMenu != 0)
            {
                Console.Clear();

                Start("You are about Bezoek...");
                Console.Write("Familienaam: ");
                string familienaam=Console.ReadLine();
                Console.Write("Voornaam: ");
                string voornaam=Console.ReadLine();

                Console.Clear();

                Start($"Welkom {familienaam} {voornaam}");
                BezoekMenu = Action("0(Overzicht) \n1(Registreer Als Lid) \n2(Item Zoeken)\n");
                switch (BezoekMenu)
                {
                    case 0:
                        Console.Clear();
                        Start("You are about to go Overzicht...");
                        Quit();
                        break;
                    case 1:
                        Console.Clear();
                        Start("You are about to Become Lid");
                        Quit();
                        break;
                    case 2:
                        Console.Clear();
                        Start("You are about to Search item");
                        Quit();
                        break;
                    default:
                        break;
                }
            }
        }
        private static void Case3() //Menu Medewerker
        {
            int MedewerkerMenu = -1;
            while (MedewerkerMenu != 0)
            {
                Start("You are about Medewereker...");
                MedewerkerMenu = Action("0(Quit) \n1(Zoek Item) \n2(Lenen) \n3(Reserveren) \n4(TerugBrengen) \n5(Historiek) \n6(UitGeleend)\n7(Gereserveerd)\n8(Promoveer een lid naar medewerker)\n9(Toevoegen item)\n10(Afvoeren item)\n");
                switch (MedewerkerMenu)
                {
                    case 0:
                        Console.Clear();
                        Start("You are about to go Overzicht...");
                        Quit();
                        break;
                    case 1:
                        Console.Clear();
                        Start("You are about to Search item");
                        Quit();
                        break;
                    case 2:
                                                Console.Clear();
                        Start("You are about to Lenen item");
                        Quit();
                        break;
                    case 3:
                                                Console.Clear();
                        Start("You are about to Reserveren item");
                        Quit();
                        break;
                    case 4:
                                                Console.Clear();
                        Start("You are about to TerugBrengen item");
                        Quit();
                        break;
                    case 5:
                                                Console.Clear();
                        Start("You are about to Historiek item");
                        Quit();
                        break;
                    case 6:
                                                Console.Clear();
                        Start("You are about to UitGeleend item");
                        Quit();
                        break;
                    case 7:
                        Console.Clear();
                        Start("You are about to Gereserveerd item");
                        Quit();
                        break;
                    case 8:
                                                Console.Clear();
                        Start("You are about to Promoveer een lid naar medewerker");
                        Quit();
                        break;
                    case 9:
                                                Console.Clear();
                        Start("You are about to Toevoegen item");
                        Quit();
                        break;
                    case 10:
                        Console.Clear();
                        Start("You are about to Afvoeren item");
                        Quit();
                        break;
                    default:
                        break;
                }
            }
        }
        private static void Case2() //Menu Lid
        {
            int LidMenu = -1;
            while (LidMenu != 0)
            {
                Start("You are about Lid...");
                LidMenu = Action("0(Quit) \n1(Zoek Item) \n2(Lenen) \n3(Reserveren) \n4(TerugBrengen) \n5(Historiek) \n6(UitGeleend)\n7(Gereserveerd)\n");
                switch (LidMenu)
                {
                    case 0:
                        Console.Clear();
                        Start("You are about to go Overzicht...");
                        Quit();
                        break;
                    case 1:
                        Console.Clear();
                        Start("You are about to Search item");
                        Quit();
                        break;
                    case 2:
                                                Console.Clear();
                        Start("You are about to Lenen item");
                        Quit();
                        break;
                    case 3:
                                                Console.Clear();
                        Start("You are about to Reserveren item");
                        Quit();
                        break;
                    case 4:
                                                Console.Clear();
                        Start("You are about to TerugBrengen item");
                        Quit();
                        break;
                    case 5:
                                                Console.Clear();
                        Start("You are about to Historiek item");
                        Quit();
                        break;
                    case 6:
                                                Console.Clear();
                        Start("You are about to UitGeleend item");
                        Quit();
                        break;
                    case 7:
                        Console.Clear();
                        Start("You are about to Gereserveerd item");
                        Quit();
                        break;
                    default:
                        break;
                }
            }
        }
        private static void Quit()
        {
            Console.WriteLine("Press any key to go back...");
            Console.ReadKey();
        }

    }
}
