using S2P1.Data;
using S2P1.Interfaces;
using S2P1.Models;
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


namespace S2P1.Repositories
{
    public class DBInitializerRepo : IDBInitializer
    {
        public void Initialize(SQLiteDBContext context)
        {
            //Name:     Initialize
            //Purpose:  To initialize the DB Database

            //Reuse:    None
            //Input:    Database context

            //Output:   None
            context.Database.EnsureCreated();

            if (context.Persons.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
           {
             new Person{Id =1,FullName="Tom Harris", Title = "Mr",
                 Address  =  new PersonAddress {PersonAddressId = 1,  AddressLine1 = "111", AddressLine2 = "Bricket Road",
                     AddressLine3 = "Extension 5", AddressLine4 = "Boksburg", AddressLine5 = "Gauteng", Code = "1000", Id = 1 } },
             new Person{Id =2,FullName="Mandy Harris", Title = "Mrs",
                 Address =  new PersonAddress {PersonAddressId = 2,  AddressLine1 = "222", AddressLine2 = "Picket Road",
                     AddressLine3 = "Extension 6", AddressLine4 = "Boksburg", AddressLine5 = "Gauteng", Code = "1000", Id = 2} },
             new Person{Id =3,FullName="Handy Harris", Title = "Mr",
                 Address =  new PersonAddress {PersonAddressId = 3,  AddressLine1 = "333", AddressLine2 = "Sticket Road",
                     AddressLine3 = "Extension 7", AddressLine4 = "Boksburg", AddressLine5 = "Gauteng", Code = "1000", Id = 3} }
           };
            foreach (Person s in people)
            {
                context.Persons.Add(s);
            }
            context.SaveChanges();
        }
    }
}
