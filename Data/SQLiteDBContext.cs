using Microsoft.EntityFrameworkCore;
using S2P1.Models;
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


namespace S2P1.Data
{
    public class SQLiteDBContext : DbContext
    {
        //Name:     SQLiteDBContext : DbContext
        //Purpose:  A databse to store all information about the person objects

        //Reuse:    None
        //Input:    Person objects

        //Output:   None
        public SQLiteDBContext(DbContextOptions<SQLiteDBContext> options) :base(options)
        { }
        public DbSet<Person> Persons { get; set; }      //
        public DbSet<PersonAddress> PersonsAddresses {get; set;}    // 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<PersonAddress>().ToTable("PersonAddress");
        }

    }
}
