using System;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
public class ListingsController : Controller

{
    public IActionResult Index()
    {
        //return Ok("This is the index of the ListingsController");
        return View(); 
    }

    public IActionResult CreateListing() 
    {
        return Ok("This is Listings/createListings");
    }
}