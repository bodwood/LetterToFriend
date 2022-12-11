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
    public string Letter() { return "Our virtual postcard will go here soon!"; }
  }
}