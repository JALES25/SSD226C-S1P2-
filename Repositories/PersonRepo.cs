using Microsoft.EntityFrameworkCore;
using S2P1.Data;
using S2P1.Interfaces;
using S2P1.Models; 
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


namespace S2P1.Repositories
{
    public class PersonRepo : IPerson
    {
        private readonly SQLiteDBContext _context;
        public PersonRepo(SQLiteDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Person> GetPerson()
        {
            //Name:     GetPerson
            //Purpose:  Public method to retrieve Person objects
            //Reuse:    None
            //Input:    none

            //Output:   Person objects- value stored in the corresponding compiler field
        
            var persons = _context.Persons.Include(c => c.Address).ToList();
            return persons;
        }
        public Person Details(int id)
        {
            //Name:     Details
            //Purpose:  Public method to provide details of the corresponding field
            //Reuse:    None
            //Input:    int id - value for corresponding compiler field

            //Output:   Person object- value stored in the corresponding compiler field
        
            var person = _context.Persons.Include(c => c.Address).Where(u => u.Id == id).FirstOrDefault();
            return person;
        }
        public Person Create(Person person)
        {
            //Name:     Person Create
            //Purpose:  Public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    Person object - value for corresponding compiler field

            //Output:   Person value- value stored in the corresponding compiler field
        
            _context.Persons.Add(person);
            _context.SaveChanges();

            _context.PersonsAddresses.Add(person.Address);
            _context.SaveChanges();
            return person; 
        }

        public Person Edit(Person person)
        {
            //Name:     Edit
            //Purpose:  Public method to edit the details of the corresponding field
            //Reuse:    None
            //Input:    Person object - value for corresponding compiler field

            //Output:   Person object- value stored in the corresponding compiler field
        
            _context.Persons.Attach(person);
            _context.Entry(person).State = EntityState.Modified;

            // Ensures that the Address property is also marked as modified // 
            _context.Entry(person).Reference(p => p.Address).IsModified = true;

            _context.SaveChanges();

            return person;
        }
        public bool Delete(Person person)  
        {
             //Name:     bool Delete
            //Purpose:  Public method to delete corresponding field
            //Reuse:    None
            //Input:    Person object - value for corresponding compiler field

            //Output:   Person value- value stored in the corresponding compiler field
        
            _context.Persons.Remove(person);
            _context.Entry(person).State = EntityState.Deleted;
            _context.SaveChanges();

            return IsExist(person.Id);
        }
        public bool IsExist(int id) 
        {
            //Name:     bool IsExist
            //Purpose:  Public method to check if an object exists
            //Reuse:    None
            //Input:    Person object Id - value for corresponding compiler field

            //Output:   bool value- true or false
        
            int personCount = _context.Persons.Where(n => n.Id == id).Count();          
            if (personCount > 0) {
                return true;
            } else {
                return false;
            }
        }
    }
}
