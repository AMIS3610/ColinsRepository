using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class MyAccountController : Controller

{
    [Route("MyAccount")]
    public IActionResult Index()
    {
        //return Ok("This is the index of the MyAccountController");
        return View(); 
    }
    [Route("MyAccount/Listings")] 
    public IActionResult MyListings() 
    {
        return Ok("This is MyAccount/MyListings");
    }

}