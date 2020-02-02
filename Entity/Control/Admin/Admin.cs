using Model.Models;
using System;
using System.Collections.Generic;

namespace Control
{
    public class Admin : IUnity
    {
        List<Unity> lstUnities = new List<Unity>();
        List<Person> lstPersons = new List<Person>();
        List<Animal> lstAnimals = new List<Animal>();
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
            throw new NotImplementedException();
        }
        public Person CreatePerson()
        {
            throw new NotImplementedException();
        }

    }
}
