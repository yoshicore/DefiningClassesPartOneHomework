using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Call
{
    private DateTime  dateAndTime;
    private string dialedPhone;
    private int duration;

    public Call(DateTime dateAndTime) : this(dateAndTime, null, 0)
    {
    }
    public Call(DateTime dateAndTime, string dialedPhone, int duration)
    {
        this.dateAndTime = dateAndTime;
        this.dialedPhone = dialedPhone;
        this.duration = duration;
    }
    
    public DateTime  DateAndTime
    {
        get 
        { 
            return this.dateAndTime; 
        }
        set 
        { 
            this.dateAndTime = value; 
        }
    }
    public string DialedNumber
    {
        get
        {
            return this.dialedPhone;
        }
        set
        {
            if (value.Length >= 0)
            {
                this.dialedPhone = value;
            }
        }
    }
    public int Duration
    {
        get
        {
            return this.duration;
        }
        set
        {
            this.duration = value;
        }
    }
}

