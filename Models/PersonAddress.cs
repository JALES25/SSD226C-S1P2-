using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Xml.Linq;
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


namespace S2P1.Models
{
    public class PersonAddress
    {
        [Key]
        public int PersonAddressId {
            //Name:     Property int PersonAddressId
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    int value-new value for corresponding compiler field

            //Output: int - value stored in the corresponding compiler field
       
             get; set;}

        [StringLength(10, ErrorMessage = "Enter Street Number")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Only Alpha numeric values allowed.")]
        [Display(Name = "Street Number")]
        public string AddressLine1 {
            //Name:     Property string AddressLine1
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    string value-new value for corresponding compiler field

            //Output: string - value stored in the corresponding compiler field
        
             get; set; }

        [StringLength(50, ErrorMessage = "Enter Street Name")]
        [Display(Name = "Street Name")]
        public string AddressLine2 {
            //Name:     Property string AddressLine2
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    string value-new value for corresponding compiler field

            //Output: string - value stored in the corresponding compiler field
      
             get; set; }
        [StringLength(50, ErrorMessage = "Enter Extension")]
        [Display(Name = "Extension")]
        public string AddressLine3 {
            //Name:     Property string AddressLine3
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    string value-new value for corresponding compiler field

            //Output: string - value stored in the corresponding compiler field
       
             get; set; }
        [StringLength(50, ErrorMessage = "Enter City")]
        [Display(Name = "City")]
        public string AddressLine4{
            //Name:     Property string AddressLine4
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    string value-new value for corresponding compiler field

            //Output: string - value stored in the corresponding compiler field
        
             get; set; }
        [StringLength(50, ErrorMessage = "Enter Province")]
        [Display(Name = "Province")]
        public string AddressLine5 {
            //Name:     Property string AddressLine5
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    string value-new value for corresponding compiler field

            //Output: string - value stored in the corresponding compiler field
         
             get; set; }
        [StringLength(10, ErrorMessage = "Enter Area Code")]
        [Display(Name = "Area Code")]
        public string Code {
            //Name:     Property string Code
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    string value -new value for corresponding compiler field

            //Output:   string - value stored in the corresponding compiler field
       
             get; set; }

        [Column("Id")]
        public int? Id {
            //Name:     int Id
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    int value-new value for corresponding compiler field

            //Output:   int - value stored in the corresponding compiler field
        
             get; set; }

        [ForeignKey(nameof(Id))]
        public Person Person {
            //Name:     Property Person Person
            //Purpose:  Automatic public property to give access to corresponding compiler field

            //Reuse:    None
            //Input:    Person value -new value for corresponding compiler field

            //Output:   Person - value stored in the corresponding compiler field
       
             get; set; }


    }
}
