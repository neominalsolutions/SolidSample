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
}
