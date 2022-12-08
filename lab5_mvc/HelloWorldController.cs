namespace lab5_mvc.controllers;

using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

public class HelloWorldController : Controller {
    public IActionResult Index()
    {
        return View();
    }
    public string Welcome()
    {
        return "會在後面接Welcome";
    }
}