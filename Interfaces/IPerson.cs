using S2P1.Models;
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


namespace S2P1.Interfaces
{
    public interface IPerson
    {
        //Name:     Interface IPerson
        //Purpose:  Provides an interface/structure for the person objects

        //Reuse:    Reusable
        //Input:    Person Objects

        //Output:   none
        IEnumerable<Person> GetPerson();
        Person Details(int id);
        Person Create(Person person);
        Person Edit(Person person);
        bool Delete(Person person);
        bool IsExist(int id);
    }
}


