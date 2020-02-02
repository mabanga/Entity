using L_Model.Models;
using System.Collections.Generic;

namespace L_Control
{
    public interface IPerson
    {
        List<Manager> InventoryManager();
        List<Employee> InventoryEmployee();
        List<Entity> InventoryEntity();
        List<Person> InventoryPerson();
        Manager CreateManager();
        Employee CreateEmployee(Person person);
        Entity CreateEntity();

        //Person ReadManager();
        //Person ReadEmployee(Person person);
        //Person ReadPerson(Person person);

        //Person UpdateManager(Person person);
        //Person UpdateEmployee(Person person);

        //bool DeleteManager(int id);
        //bool DeleteEmployee(int id);


    }
}
