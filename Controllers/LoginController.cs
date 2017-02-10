using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class LoginController : Controller

{
   
    public IActionResult Index()
    {
            //return Ok("This is the index of the LoginController");         
            return View(); 
    }

    public IActionResult Register() 
    {
        return Ok("This is Login/Register");
    }
    
}