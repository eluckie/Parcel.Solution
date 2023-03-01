using System.Collections.Generic;

namespace Parcel.Models
{
  public class Package
  {
    public int Length { get; set; }
    public Package(int length)
    {
      Length = length;
    }
  }
}