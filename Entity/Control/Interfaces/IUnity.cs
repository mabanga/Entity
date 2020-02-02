using Model.Models;
using System.Collections.Generic;

namespace Control
{
    public interface IUnity
    {
        List<Person> Persons();
        List<Animal> Animals();
        List<Unity> Unities();
        Person CreatePerson();
        Animal CreateAnimal();
    }
}
