using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController: Controller
  {
    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/formbirthdayparty")]
    public ActionResult FormBirthdayParty() { return View(); }
    
    [Route("/madlibs")]
    public ActionResult MadLibs(string verb1, string noun1, string food1, string food2, string timeofday1, string noun2, string acronym1, string country1)
    {
      MadLibsVariable madLibsVariable = new MadLibsVariable();
      madLibsVariable.Verb1 = verb1;
      madLibsVariable.Noun1 = noun1;
      madLibsVariable.Food1 = food1;
      madLibsVariable.Food2 = food2;
      madLibsVariable.TimeOfDay1 = timeofday1;
      madLibsVariable.Noun2 = noun2;
      madLibsVariable.Acronym1 = acronym1;
      madLibsVariable.Country1 = country1;
      return View(madLibsVariable);
    }

    [Route("/birthdayparty")]
    public ActionResult BirthdayParty(string event1, string number1, string name1, string activity1, string name2, string relation1, string favoritetype, string favoritething)
    {
      BirthdayPartyVariable birthdayPartyVariable = new BirthdayPartyVariable();
      birthdayPartyVariable.Event1 = event1;
      birthdayPartyVariable.Number1 = number1;
      birthdayPartyVariable.Name1 = name1;
      birthdayPartyVariable.Activity1 = activity1;
      birthdayPartyVariable.Name2 = name2;
      birthdayPartyVariable.Relation1 = relation1;
      birthdayPartyVariable.FavoriteThing = favoritething;
      birthdayPartyVariable.FavoriteType = favoritetype;
      return View(birthdayPartyVariable);
    }
  }
}