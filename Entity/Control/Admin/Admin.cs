using Model.Models;
using System;
using System.Collections.Generic;

namespace Control
{
    public class Admin : IUnity
    {
        int _id = 111;
        List<Unity> lstUnities = new List<Unity>();
        List<Person> lstPersons = new List<Person>();
        List<Animal> lstAnimals = new List<Animal>();
        //Animal addedAnimal= new Animal("animal");
        public List<Unity> Unities()

        {
            return lstUnities;
        }
        public List<Animal> Animals()
        {
            return lstAnimals;
        }
        public List<Person> Persons()
        {
            return lstPersons;
        }
        public Animal CreateAnimal()
        {
            Animal addedAnimal = new Animal { Gender = Gender.Undefined };

            Console.Write("FirstName: ");
            string firstname = Console.ReadLine();
            System.Console.Write($"Last Name: ");
            string lastName = System.Console.ReadLine();
            System.Console.Write("Street: ");
            string street = System.Console.ReadLine();
            System.Console.Write("House Number: ");
            string number = System.Console.ReadLine();
            System.Console.Write("Postbox: ");
            string postbox = System.Console.ReadLine();
            System.Console.Write("Zipcode: ");
            string zipcode = System.Console.ReadLine();
            System.Console.Write("City: ");
            string city = System.Console.ReadLine();

                int value = Action("Gender: 1.Male   0.Female");
                if (value==1)
                {
                  addedAnimal.Gender = Gender.Male;
                }
                else if (value==0)
                {
                    addedAnimal.Gender = Gender.Female;
                }
                else
                {
                    addedAnimal.Gender = Gender.Undefined;
                }

            System.Console.Write("Birth Date: ");
            DateTime birthdate = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("Dead Date: ");
            DateTime deaddate = Convert.ToDateTime(System.Console.ReadLine());
            addedAnimal = new Animal()
            {

                Address = new Address(street, number, postbox, zipcode, city),
                Name = new Name(firstname, " ", lastName),
                BirthDate = birthdate,
                Gender = addedAnimal.Gender,
                ID = _id++
            };
            lstUnities.Add(addedAnimal);
            lstAnimals.Add(addedAnimal);
            return addedAnimal;
        }
        public Person CreatePerson()
        {
            
            Console.CursorVisible = true;
            Person addedPerson = new Person { Gender = Gender.Undefined };
            Console.SetCursorPosition(25, 12);
            Console.Write("FirstName: ");
            Console.SetCursorPosition(60, 12);
            Console.Write($"LastName: ");
            Console.SetCursorPosition(25, 13);
            System.Console.Write("Married: ");

            Console.SetCursorPosition(25, 14);
            System.Console.Write("Street: ");
            Console.SetCursorPosition(60, 14);
            System.Console.Write("Number: ");
            Console.SetCursorPosition(75, 14);
            System.Console.Write("PostBox: ");
            Console.SetCursorPosition(25, 15);
            System.Console.Write("zipcode: ");
            Console.SetCursorPosition(60, 15);
            System.Console.Write("city: ");
            Console.SetCursorPosition(25, 16);
            System.Console.Write("Birth Date: ");


            Console.SetCursorPosition(35, 12);
            string firstname = Console.ReadLine();
            Console.SetCursorPosition(69, 12);
            string lastName = Console.ReadLine();
            Console.SetCursorPosition(32, 13);
            bool ismaried = bool.Parse(System.Console.ReadLine());
            Console.SetCursorPosition(32, 14);
            string street = Console.ReadLine();
            Console.SetCursorPosition(67, 14);
            string number = System.Console.ReadLine();
            Console.SetCursorPosition(83, 14);
            string postbox = System.Console.ReadLine();
            Console.SetCursorPosition(33, 15);
            string zipcode = System.Console.ReadLine();
            Console.SetCursorPosition(65, 15);
            string city = System.Console.ReadLine();
            Console.SetCursorPosition(36, 16);
            DateTime birthdate = Convert.ToDateTime(System.Console.ReadLine());

            Console.SetCursorPosition(60, 13);

            int value = -1;

            value = Action("Gender: (1)M - (0)F: ");
            if (value == 1)
            {
                addedPerson.Gender = Gender.Male;
            }
            else if (value == 0)
            {
                addedPerson.Gender = Gender.Female;
            }
            else
            {
                addedPerson.Gender = Gender.Undefined;
            }

            //System.Console.Write("Dead Date: ");
            //DateTime deaddate = Convert.ToDateTime(System.Console.ReadLine());
            addedPerson = new Person()
            {
                Address = new Address(street, number, postbox, zipcode, city),
                Name = new Name(firstname, " ", lastName),
                BirthDate = birthdate,
                Gender = addedPerson.Gender,
                isMaried = ismaried,
                ID = _id++
            };
            lstUnities.Add(addedPerson);
            lstPersons.Add(addedPerson);
            Console.Clear();
            return addedPerson;
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
