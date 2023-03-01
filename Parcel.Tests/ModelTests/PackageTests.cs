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
      Package newPackage = new Package(5, 5);
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }

    [TestMethod]
    public void GetPackageLength_ReturnsPackageLength_Int()
    {
      int packageLength = 5;
      Package newPackage = new Package(5, 5);
      int result = newPackage.Length;
      Assert.AreEqual(packageLength, result);
    }

    [TestMethod]
    public void GetPackageWidth_ReturnsPackageWidth_Int()
    {
      int packageWidth = 5;
      Package newPackage = new Package(5, 5);
      int result = newPackage.Width;
      Assert.AreEqual(packageWidth, result);
    }
  }
}
