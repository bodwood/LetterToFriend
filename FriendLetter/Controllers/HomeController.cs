using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.controller
{
  public class HomeController : Controller  // HomeController inherits ASP,NET Core's functionality from : Controller 
  {
    [Route("/hello")] //Route overrides default URL path 
    public string Hello() { return "Hello Friend!"; } //Hello() represents a route

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; } //Goodbye() represents a route

    [Route("/")]
    public ActionResult Letter() { return View(); } //ActionResult handles redering views. View() is a built-in method from .Mvc namepace
  }
}