using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route ("/")]
    public ActionResult Libs()
    {
      LibsVariable myLibsVariable = new LibsVariable();
      myLibsVariable.SetSubject("Subject");
      myLibsVariable.SetEmotion1("emotion1");
      myLibsVariable.SetPlace("place");
      myLibsVariable.SetNoun("noun");
      myLibsVariable.SetEmotion2("emotion2");
      myLibsVariable.SetBodyFunction("bodyFunction");
      myLibsVariable.SetClothingItem("clothing");
      return View(myLibsVariable);
    }

    [Route ("/Form")]
    public ActionResult Form()
    {
      return View();
    }
    [Route ("/Game")]
    public ActionResult Game(string subject, string emotion1, string place, string noun, string emotion2, string bodyFunction, string clothingItem)
    {
      LibsVariable myLibsVariable = new LibsVariable();
      myLibsVariable.SetSubject(subject);
      myLibsVariable.SetEmotion1(emotion1);
      myLibsVariable.SetPlace(place);
      myLibsVariable.SetNoun(noun);
      myLibsVariable.SetEmotion2(emotion2);
      myLibsVariable.SetBodyFunction(bodyFunction);
      myLibsVariable.SetClothingItem(clothingItem);
      return View(myLibsVariable);
    }
  }
}
