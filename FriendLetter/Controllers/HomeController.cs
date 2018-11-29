using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Letter() 
    { 
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Lina");
      myLetterVariable.SetSender("George");
      return View(myLetterVariable); 
    }

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye my man!"; }

    [Route("/journal")]
    public ActionResult Journal() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }
      
    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender) 
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(recipient);
      myLetterVariable.SetSender(sender);
      return View(myLetterVariable);
    }

    [Produces("text/html")]
    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }
  }
}