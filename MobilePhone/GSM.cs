using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GSM
{
    private string model;
    private string manufacturer;
    private int? price;
    private string owner;

    //GSM Call History 
    private List<Call> callHistory;

    //holding instances for Battery and Display
    public Battery battery = new Battery();
    public Display display = new Display();

    //GSM static field
    public static GSM iPhone = new GSM("iPhone4S", "Apple", 999);

    //GSM Constructors
    public GSM(string model, string manufacturer) : this(model, manufacturer, 0, null, null, null)
    {
        this.callHistory = new List<Call>();
    }
    public GSM(string model, string manufacturer, int? price) : this(model, manufacturer, price, null, null, null)
    {
        this.callHistory = new List<Call>();
    }
    public GSM(string model, string manufacturer, int? price, string owner) 
        : this(model, manufacturer, price, owner, null, null)
    {
    }
    public GSM(string model, string manufacturer, int? price, string owner, Battery battery, Display display)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
        this.display = display;
    }

    //GSM Properties
    public List<Call> CallHistory
    {
        get
        {
            return this.callHistory;
        }
        set
        {
            this.callHistory = value;
        }
    }

    public static GSM IPhone
    {
        get 
        { 
            return iPhone; 
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
            if (value.Length >= 0)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value.Length >= 0)
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    public int? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value >= 0 || value == null)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            if (value.Length >= 0 || value == null)
            {
                this.owner = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    //GSM Methods
    public void AddCall(DateTime dateAndTime, string dialedPhone, int duration)
    {
        this.callHistory.Add(new Call(dateAndTime, dialedPhone, duration));
    }
    public void DeleteCall(int callCounter)
    {
        this.CallHistory.RemoveAt(callCounter);
    }
    public void ClearHistory()
    {
        this.CallHistory.Clear();
    }

    public string TotalPrice(double pricePerMinute)
    {
        double totalTimeTalked = 0;
        foreach (var Call in this.CallHistory)
        {
            totalTimeTalked += Call.Duration;
        }
        double totalPrice = (totalTimeTalked / 60) * pricePerMinute;
        return string.Format("The Total Price of all Conversations is : {0:0.00}", totalPrice);
    }

    public override string ToString()
    {
        return string.Format("Model:{0}, Manufacturer:{1}, Price:{2}$ ,Owner:{3} , Battery:{4} , Display:{5}",
            this.model, this.manufacturer, this.price, this.owner, this.battery, this.display );
    }
}