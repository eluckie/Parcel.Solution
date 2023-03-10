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
      Package newPackage = new Package(5, 6, 7, 10);
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }

    [TestMethod]
    public void GetPackageLength_ReturnsPackageLength_Int()
    {
      int packageLength = 5;
      Package newPackage = new Package(5, 6, 7, 10);
      int result = newPackage.Length;
      Assert.AreEqual(packageLength, result);
    }

    [TestMethod]
    public void GetPackageWidth_ReturnsPackageWidth_Int()
    {
      int packageWidth = 6;
      Package newPackage = new Package(5, 6, 7, 10);
      int result = newPackage.Width;
      Assert.AreEqual(packageWidth, result);
    }

    [TestMethod]
    public void GetPackageHeight_ReturnsPackageHeight_Int()
    {
      int packageHeight = 7;
      Package newPackage = new Package(5, 6, 7, 10);
      int result = newPackage.Height;
      Assert.AreEqual(packageHeight, result);
    }

    [TestMethod]
    public void GetPackageWeight_ReturnsPackageWeight_Int()
    {
      int packageWeight = 10;
      Package newPackage = new Package(5, 6, 7, 10);
      int result = newPackage.Weight;
      Assert.AreEqual(packageWeight, result);
    }

    [TestMethod]
    public void Volume_ReturnsPackageVolume_Int()
    {
      Package newPackage = new Package(5, 6, 7, 10);
      int result = 5 * 6 * 7;
      int packageVolume = newPackage.Volume();
      Assert.AreEqual(result, packageVolume);
    }

    [TestMethod]
    public void CostToShip_ReturnsPackagesCostToShip_Int()
    {
      Package newPackage = new Package(5, 6, 7, 10);
      int result = (6 * 7) / 10;
      int packageCost = newPackage.CostToShip();
      Assert.AreEqual(result, packageCost);
    }
  }
}
