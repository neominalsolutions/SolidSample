using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.LSP
{
  public abstract class BestShapeBase
  {
    public abstract double GetPerimeter();
    public abstract double GetArea();
  }

  public class BestSquare : BestShapeBase
  {
    public double Corner { get; set; }

    public override double GetArea()
    {
      return Math.Pow(this.Corner,2);
    }

    public override double GetPerimeter()
    {
      return this.Corner * 4;
    }
  }

  public class BestRect : BestShapeBase
  {
    public double Width { get; set; }
    public double Height { get; set; }


    public override double GetArea()
    {
      return this.Width * this.Height;
    }

    public override double GetPerimeter()
    {
      return 2 * this.Width + 2 * this.Height;
    }
  }

  public class Triangle : BestShapeBase
  {
    public double Acorner { get; set; }
    public double Bcorner { get; set; }
    public double Ccorner { get; set; }


    public override double GetArea()
    {
      throw new NotImplementedException();
    }

    public override double GetPerimeter()
    {
      throw new NotImplementedException();
    }
  }
}
