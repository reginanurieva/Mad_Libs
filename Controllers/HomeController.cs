using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller

  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Produces("text/html")]
    [Route("/mad_libs")]
    public ActionResult Story()
    {
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.SetPerson1(Request.Query["person1"]);
      myStoryVariable.SetPerson2(Request.Query["person2"]);
      myStoryVariable.SetAnimal(Request.Query["animal"]);
      myStoryVariable.SetExclamation(Request.Query["exclamation"]);
      myStoryVariable.SetVerb(Request.Query["verb"]);
      myStoryVariable.SetNoun(Request.Query["noun"]);

      return View("Story", myStoryVariable);
    }
  }
}
