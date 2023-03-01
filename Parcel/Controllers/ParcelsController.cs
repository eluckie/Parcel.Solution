using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class ParcelsController : Controller
  {
    [Route("/path")]
    public ActionResult Path()
    {
      ClassName variableName = new ClassName();
      variableName.PropertyName = "";
      return View(variableName);
    }
  }
}