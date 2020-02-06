using L_Model.Models;
using System;
using System.Collections.Generic;

namespace L_Control
{
    public class PersonAdmin : IPerson
    {
        int _id = 111;
        List<Person> people = new List<Person>();
        List<Employee> listEmployee = new List<Employee>();
        List<Manager> listManager = new List<Manager>();
        List<Entity> listEntity = new List<Entity>();
        Employee IPerson.CreateEmployee(Person person)
        {
            Employee addedEmployee;
            listEmployee.Add(addedEmployee = new Employee()
            {
                Address = person.Address,
                Name = person.Name,
                BirthDate = person.BirthDate,
                Gender = person.Gender,
                isMaried = person.isMaried,
                ID = _id++
            });
            people.Add(addedEmployee);
            listEntity.Add(addedEmployee);
            return addedEmployee;
        }
        Manager IPerson.CreateManager()
        {
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
            System.Console.Write("Birth Date: ");
            DateTime birthdate = Convert.ToDateTime(System.Console.ReadLine());

            System.Console.Write("Gender: ");
            string gender = System.Console.ReadLine();
            Manager addedManager;
            listManager.Add(addedManager = new Manager()
            {
                Address = new Address(street, number, postbox, zipcode, city),
                Name = new Name(firstname, " ", lastName),
                BirthDate = birthdate,
                //Gender = (Gender)gender,
                isMaried = ismaried,
                ID = _id++
            });
            people.Add(addedManager);
            listEntity.Add(addedManager);
            return addedManager;
        }
        public Entity CreateEntity()
        {
            //if (firstname.Trim() == string.Empty || firstname.Trim() == null)
            //{
            //    =firstname.Trim(' ').Replace(" ", "");
            //}
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
            System.Console.Write("Birth Date: ");
            DateTime birthdate = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("Gender: ");
            string gender = System.Console.ReadLine();
            Entity addedEntity;
            listEntity.Add(addedEntity = new Entity()
            {
                Address = new Address(street,number,postbox,zipcode,city),
                Name = new Name(firstname, " ", lastName),
                BirthDate = birthdate,
                //Gender = (Gender)gender,
                isMaried = ismaried,
                ID = _id++
            }); 
            people.Add(addedEntity);

            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}
            return addedEntity;
        }
        public List<Manager> InventoryManager()
        {
            return listManager;
        }
        public List<Employee> InventoryEmployee()
        {
            return listEmployee;
        }
        public List<Entity> InventoryEntity()
        {
            return listEntity;
        }
        //public Person CreateManager(Person person)
        //{
        //    Manager addedManager;
        //    listManager.Add(addedManager = new Manager()
        //    {
        //        Address = person.Address,
        //        Name = person.Name,
        //        BirthDate = person.BirthDate,
        //        Gender = person.Gender,
        //        ID = _id++
        //    });
        //    return addedManager;
        //}
        public bool DeleteManager(int id)
        {
            throw new NotImplementedException();
        }
        public void ReadManager()
        {
            foreach (var item in listManager)
            {
                Console.WriteLine(item);
            }
        }
        public Person UpdateManager(Person person)
        {
            throw new NotImplementedException();
        }
        public List<Person> InventoryPerson()
        {
            return people;
        }
        public Person ReadEmployee(Person person)
        {
            throw new NotImplementedException();
        }
        public Person ReadPerson(Person person)
        {
            throw new NotImplementedException();
        }
        public Person UpdateEmployee(Person person)
        {
            throw new NotImplementedException();
        }
        public bool DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
        public void Create()
        {
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
            System.Console.Write("Birth Date: ");
            DateTime birthdate = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("Gender: ");
            string gender = System.Console.ReadLine();
        }
    }
}
