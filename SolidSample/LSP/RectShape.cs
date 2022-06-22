using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.LSP
{
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
}
