using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.controller
{
  public class HomeController : Controller  // HomeController inherits ASP,NET Core's functionality from : Controller 
  {
    [Route("/hello")] //Route overrides default URL path 
    public string Hello() { return "Hello Friend!"; } //Hello() represents a route

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; } //Goodbye() represents a route

    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable(); //new instance of LetterVariable
      myLetterVariable.Recipient = "Bodie"; //use LetterVariable instance to set name of recipient to Bodie
      myLetterVariable.Sender = "Kadysha";  //use LetterVariable instance to set name of sender to Kadysha
      return View(myLetterVariable);  //return the view of the new instance 
    } //ActionResult handles redering views. View() is a built-in method from .Mvc namepace

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender) //take in recipient and sender from form
    {
      LetterVariable myLetterVariable = new LetterVariable(); //new instance of LetterVariable
      myLetterVariable.Recipient = recipient; //set recipitent property to recipient from parameter
      myLetterVariable.Sender = sender; //set sender property to sender from parameter
      return View(myLetterVariable);  //return instancel
    }
  }
}