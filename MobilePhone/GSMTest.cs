using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GSMTest
{
    static void Main()
    {
        //GSM Test
        GSM[] testArray = new GSM[5];
        string[] models = {"iPhone 5", "Galaxy S", "Galaxy S2", "Xperia", "One X"};
        string[] manufacturers = { "Apple", "Samsung", "Samsung", "Nokia", "HTC" };
        int[] prices = { 1111, 500, 666, 444, 555 };

        for (int i = 0; i < testArray.Length; i++)
        {
            testArray[i] =new GSM(models[i], manufacturers[i], prices[i]);
            Console.WriteLine(testArray[i].ToString());
        }
        Console.WriteLine("Model:{0} Manufacturer:{1}   Cost:{2}$",GSM.iPhone.Model, GSM.iPhone.Manufacturer, GSM.iPhone.Price);
        Console.WriteLine();
       
        //Testing GSMCallHistory

        //creating instance of GSM
        GSM testGSM = new GSM("EVO3D", "HTC", 611);
        //adding few calls
        testGSM.AddCall( DateTime.Now,"0888 888 888", 33);
        testGSM.AddCall(DateTime.Now, "0877 777 777", 77);
        testGSM.AddCall(DateTime.Now, "0899 999 999", 111);
        //displaying info about the calls
        foreach (var Call in testGSM.CallHistory)
        {
            Console.WriteLine(Call.DateAndTime);
            Console.WriteLine("dialed number : {0}",Call.DialedNumber);
            Console.WriteLine("call duration : {0}secondes",Call.Duration);
            Console.WriteLine();
        }
        //printing the total price of the calls
        Console.WriteLine("{0} lv",testGSM.TotalPrice(0.37));
        //deleting the longest call and printing the total price again
        int longestCall = 0;
        int longestDuration = 0;
        for (int i = 0; i < testGSM.CallHistory.Count; i++)
        {
            if (testGSM.CallHistory[i].Duration > longestDuration)
            {
                longestDuration = testGSM.CallHistory[i].Duration;
                longestCall = i;
            }
        }
        testGSM.DeleteCall(longestCall);
        Console.WriteLine("After deleting the longest call...");
        Console.WriteLine("{0} lv", testGSM.TotalPrice(0.37));
        //clearing and printing again call history
        testGSM.ClearHistory();
        Console.WriteLine("After deleting all calls...");
        Console.WriteLine("{0} lv", testGSM.TotalPrice(0.37));
    }
}

