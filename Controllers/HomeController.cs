using System;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class HomeController : Controller

{
        public IActionResult Index()
    {
        //return Ok("This is the index of the HomeController");
        return View(); 
    }

    
}