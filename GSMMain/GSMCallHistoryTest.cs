using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GSMMain
{
    

    public class GSMCallHistoryTest
    {
        private const decimal charge = (decimal)0.37;

        public void HistoryTest ()
        {
            GSM firstPhone = new GSM("N100", "Nokia", 100.98, "Pesho");
            firstPhone.AddCall(new Call(DateTime.Parse("12/02/2015 19:23:34"), "388297912", 435));
            firstPhone.AddCall(new Call(DateTime.Parse("15/03/2015 14:22:31"), "388297912654", 60));
            firstPhone.AddCall(new Call(DateTime.Parse("23/03/2015 21:45:21"), "5466388297912", 100));
            firstPhone.AddCall(new Call(DateTime.Parse("23/03/2015 22:45:21"), "38845244597912", 126));
            Console.WriteLine(firstPhone.PrintCallHistory());
            Console.WriteLine("The total price of the calls in the call history is: {0}.", firstPhone.TotalCostOfCalls(charge));
            Console.WriteLine();

            Call longestCall = firstPhone.CallHistory.OrderBy(x => x.Duration).ToArray()[firstPhone.CallHistory.Count - 1];
            firstPhone.RemoveCall(longestCall);          
            Console.WriteLine(firstPhone.PrintCallHistory());
            Console.WriteLine("The total price of the calls in the call history is: {0}.", firstPhone.TotalCostOfCalls(charge));
            Console.WriteLine();

            firstPhone.ClearCalls();
            Console.WriteLine(firstPhone.PrintCallHistory());
        }      

    }
}
