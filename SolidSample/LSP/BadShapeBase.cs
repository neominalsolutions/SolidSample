using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.LSP
{

  public abstract class BadShapeBase
  {
    public double Width { get; set; }
    public double Height { get; set; }

    public abstract double GetPerimeter();
    public abstract double GetArea();
  }

  public class RectShape : BadShapeBase
  {

    public override double GetArea()
    {
      return this.Width * this.Height;
    }

    public override double GetPerimeter()
    {
      return 2 * this.Width + 2 * this.Height;
    }
  }


  public class SquareShape : BadShapeBase
  {
    public override double GetArea()
    {

      if (this.Width == 0 && this.Height > 0)
      {
        return this.Height * this.Height;
      }

      return this.Width * this.Width;
    }

    public override double GetPerimeter()
    {
      if (this.Width == 0 && this.Height > 0)
      {
        return this.Height * 4;
      }


      return this.Width * 4;
    }
  }

}
