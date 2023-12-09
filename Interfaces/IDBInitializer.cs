using S2P1.Data;
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


namespace S2P1.Interfaces
{
    public interface IDBInitializer
    {
        //Name:     Interface IDBInitializer
        //Purpose:  To initialize the DB Database 

        //Reuse:    None
        //Input:    Person objects

        //Output:   None
        void Initialize(SQLiteDBContext context);
    }
}
