using System.ComponentModel.DataAnnotations;
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


namespace S2P1.Models
{
    public class Person
    {
        [Key]
        public int Id { 
            //Name:     Property int Id
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    int value-new value for corresponding compiler field

            //Output: int - value stored in the corresponding compiler field
        
            get; set; }

        [StringLength(50, ErrorMessage = "Enter Name and Surname.")]
        [Display(Name = "Full Name")]
        public string FullName {
            //Name:     Property string Full Name
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    string value-new value for corresponding compiler field

            //Output: string - value stored in the corresponding compiler field

             get; set; }

        [StringLength(5, ErrorMessage = "Enter Abbreviated Title")]
        [Display(Name = "Title")]
        public string Title {
            //Name:     Property string Title
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    string value-new value for corresponding compiler field

            //Output: string - value stored in the corresponding compiler field
       
             get; set; }
        public PersonAddress Address {
            //Name:     Property PersonAddress Address
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    PersonAddress value-new value for corresponding compiler field

            //Output: PersonAddress - value stored in the corresponding compiler field
     
             get; set; }

    }
}
