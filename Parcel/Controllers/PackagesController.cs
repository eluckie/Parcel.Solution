using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class ParcelsController : Controller
  {
    [Route("/parcels/item")]
    public ActionResult Item(int length, int width, int height, int weight)
    {
      Package newPackage = new Package(length, width, height, weight);
      newPackage.Length = length;
      newPackage.Width = width;
      newPackage.Height = height;
      newPackage.Weight = weight;
      return View(newPackage);
    }
  }
}