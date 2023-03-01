using System.Collections.Generic;

namespace Parcel.Models
{
  public class Package
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public Package(int length, int width)
    {
      Length = length;
      Width = width;
    }
  }
}