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
            Person addedPerson = new Person { Gender = Gender.Undefined };

            Console.Write("FirstName: ");
            string firstname = Console.ReadLine();
            System.Console.Write($"Last Name: ");
            string lastName = System.Console.ReadLine();
            System.Console.Write("Maried: ");
            bool ismaried = bool.Parse(System.Console.ReadLine());
            System.Console.Write("Street: ");
            string street = System.Console.ReadLine();
            System.Console.Write("numbner: ");
            string number = System.Console.ReadLine();
            System.Console.Write("postbox: ");
            string postbox = System.Console.ReadLine();
            System.Console.Write("zipcode: ");
            string zipcode = System.Console.ReadLine();
            System.Console.Write("city: ");
            string city = System.Console.ReadLine();
            int value = -1;

            value = Action("Gender: 1.Male   0.Female: ");
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
            System.Console.Write("Birth Date: ");
            DateTime birthdate = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("Dead Date: ");
            DateTime deaddate = Convert.ToDateTime(System.Console.ReadLine());
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
