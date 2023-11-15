using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.LSP
{

  // Bir sınıf kalıtım alınan sınıfın özelliklerine uymak zorundadır.
  // ortak özellikleri korumalıdır. 

  public abstract class BadShapeBase
  {
    public double Width { get; set; }
    public double Height { get; set; }

    public abstract double GetPerimeter();
    public abstract double GetArea();
  }

  // Dikdörtgen
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

      if (this.Width == this.Height)
      {
        return this.Height * this.Height;
      } 
      else
      {
        throw new Exception("Bu şekil kare özelliği göstermiyor");
      }
    }

    public override double GetPerimeter()
    {
      if (this.Width == this.Height)
      {
        return this.Height * 4;
      } 
      else
      {
        throw new Exception("Bu şekil kare olamaz");
      }

    }
  }

}
