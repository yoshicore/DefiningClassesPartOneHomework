using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Display
{
    private int? size;
    private int? numberOfColors;

    //Display Constructors
    public Display() : this(0, 0)
    {
    }
    public Display(int? size, int? numberOfColors)
    {
        this.size = size;
        this.numberOfColors = numberOfColors;
    }

    //Display Properties
    public int? Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value >= 0 || value == null)
            {
                this.size = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    public int? NumberOfColors
    {
        get
        {
            return this.numberOfColors;
        }
        set
        {
            if (value >= 0 || value == null)
            {
                this.numberOfColors = value;
            }
        }
    }
    public override string ToString()
    {
        return string.Format("Display Size:{0} Number of Colors:{1}",
            this.size, this.numberOfColors);
    }
}

