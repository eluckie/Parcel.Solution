using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcel.Models;

namespace Parcel.Tests
{
  [TestClass]
  public class PackageTests
  {
    [TestMethod]
    public void PackageConstructor_ShouldCreateAnInstanceOfPackage_Package()
    {
      Package newPackage = new Package();
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }

  }
}
