using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.LSP
{
  public abstract class BestShapeBase
  {
    public double Length { get; set; }
    public abstract double GetPerimeter();
    public abstract double GetArea();
  }

  public class BestSquare : BestShapeBase
  {
    public override double GetArea()
    {
      return Math.Pow(this.Length,2);
    }

    public override double GetPerimeter()
    {
      return this.Length * 4;
    }
  }

  public class BestRect : BestShapeBase
  {
    public double Width { get; set; }

    public override double GetArea()
    {
      return this.Length * this.Width;
    }

    public override double GetPerimeter()
    {
      return 2 * this.Length + 2 * this.Width;
    }
  }
}
