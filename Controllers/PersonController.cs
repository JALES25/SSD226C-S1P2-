using Microsoft.AspNetCore.Mvc;
using S2P1.Models;
using S2P1.Interfaces;
using S2P1.Repositories;
//Group Assignmnent :   S2P2
//Student numbers   :221004954;219014233;222006734;220003789
//Purpose:          :The purpose of this program is to provide the user with a web based page of the people stored in the database and display their information details.


namespace S2P1.Controllers
{
    public class PersonController : Controller
    {   
        private readonly IPerson _personRepo;
        public PersonController(IPerson personRepo)
        {
            _personRepo = personRepo;
        }
        public IActionResult Index()
        {
            //Name:     IActionResult Index
            //Purpose:  Return Default View of the Person Objects in the index view

            //Reuse:    Reusable
            //Input:    None

            //Output:   Ouputs a View of Index 
            IEnumerable<Person> person = _personRepo.GetPerson();
            return View(person);              
        }


        [HttpGet]
        public IActionResult Details(int Id)
        {
            //Name:     IActionResult Details
            //Purpose:  Return a view of the Person Objects using their ID

            //Reuse:    Reusable
            //Input:    Person object id

            //Output:   Ouputs a View of Details of the Person objects
       
            return View(_personRepo.Details(Id)); 
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Name:     IActionResult Create
            //Purpose:  Create a new person object

            //Reuse:    Reusable
            //Input:    None

            //Output:   Outputs the person object if all conditions are valid
      
            Person person = new Person();
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, FullName, Title, Address")] Person person)
        {
            //Name:     IActionResult Create
            //Purpose:  Create a new person object

            //Reuse:    Reusable
            //Input:    Person object

            //Output:   Outputs the person object if all conditions are valid
      
            try
            {
                if (ModelState.IsValid)
                {

                    _personRepo.Create(person);
                }
            }
            catch {}

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Name:     IActionResult Edit
            //Purpose:  Edit an existing person object

            //Reuse:    Reusable
            //Input:    Person object id

            //Output:   Outputs the person object has been edited.
      
            return View(_personRepo.Details(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id, FullName, Title, Address.PersonAddressId, Address.AddressLine1, Address.AddressLine2, Address.AddressLine3, Address.AddressLine4, Address.AddressLine5, Address.Code")] Person person)
        {
            if (ModelState.IsValid)
            {
                _personRepo.Edit(person);
            }
            return RedirectToAction(nameof(Index));
        }

        

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //Name:     IActionResult Delete
            //Purpose:  Delete a existing person object

            //Reuse:    Reusable
            //Input:    Person object id

            //Output:   Outputs the person object to be deleted
      
            return View(_personRepo.Details(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, [Bind("Id, FullName, Title, Address.PersonAddressId, Address.AddressLine1, Address.AddressLine2, Address.AddressLine3, Address.AddressLine4, Address.AddressLine5, Address.Code")] Person person)
        {
            //Name:     IActionResult Delete
            //Purpose:  Delete a existing person object

            //Reuse:    Reusable
            //Input:    Person Object id

            //Output:   Outputs the person object has been deleted
      
            _personRepo.Delete(_personRepo.Details(id));


            return RedirectToAction(nameof(Index));
        }


        private IEnumerable<Person> GetPeople ()
        {
            //Name:     IEnumerable<Person> GetPeople
            //Purpose:  To make a list of all the People objects

            //Reuse:    Reusable
            //Input:    Person objects

            //Output:   Output list of the Person objects

            var people = new Person[]   
           {
             new Person{Id =1,FullName="Tom Harris", Title = "Mr",
                 Address  =  new PersonAddress {PersonAddressId = 1,  AddressLine1 = "111", AddressLine2 = "Bricket Road", 
                     AddressLine3 = "Extension 5", AddressLine4 = "Boksburg", AddressLine5 = "Gauteng", Code = "1000" } },
             new Person{Id =2,FullName="Mandy Harris", Title = "Mrs",
                 Address =  new PersonAddress {PersonAddressId = 2,  AddressLine1 = "222", AddressLine2 = "Picket Road", 
                     AddressLine3 = "Extension 6", AddressLine4 = "Boksburg", AddressLine5 = "Gauteng", Code = "1000" } },
             new Person{Id =3,FullName="Handy Harris", Title = "Mr",
                 Address =  new PersonAddress {PersonAddressId = 3,  AddressLine1 = "333", AddressLine2 = "Sticket Road", 
                     AddressLine3 = "Extension 7", AddressLine4 = "Boksburg", AddressLine5 = "Gauteng", Code = "1000" } }
           };
            return people.ToList();
        }
    }
}
