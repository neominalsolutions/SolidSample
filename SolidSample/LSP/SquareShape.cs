using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.LSP
{
  public class SquareShape : BadShapeBase
  {
    public override double GetArea()
    {

      if(this.Width == 0 && this.Height > 0)
      {
        return this.Height * this.Height;
      }

      return this.Width * this.Width;
    }

    public override double GetPerimeter()
    {
      if(this.Width == 0 && this.Height > 0)
      {
        return this.Height * 4;
      }


      return this.Width * 4;
    }
  }
}
