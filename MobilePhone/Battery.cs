using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Enumeration for BatteryType
public enum BatteryType
{
    LiIon, LiPol, NiMH, NiCd
}

public class Battery
{
    private BatteryType batteryType;
    private string model;
    private int? hoursIdle;
    private int? hoursTalk;

    //Battery Constructors
    public Battery()  
    {
    }
    public Battery(BatteryType batteryType) : this(batteryType, null, 0, 0)
    {
    }
    public Battery(BatteryType batteryType, string model, int? hoursIdle, int? hoursTalk)
    {
        this.batteryType = batteryType;
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
    }

    //Battery Properties
    public BatteryType BatteryType
    {
        get
        {
            return this.batteryType;
        }
        set
        {
            this.batteryType = value;
        }
    }
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value.Length >= 0 || value == null)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    public int? HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            if (value >= 0 || value == null)
            {
                this.hoursIdle = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    public int? HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            if (value >= 0 || value == null)
            {
                this.hoursTalk = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    public override string ToString()
    {
        return string.Format("Battery Type:{0} Battery Model:{1} Hours Idle:{2} Hours Talk:{3}",
            this.batteryType, this.model, this.hoursIdle, this.hoursTalk);
    }
}

