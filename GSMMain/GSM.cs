namespace GSMMain
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        public static string IPhone4S = "The iPhone 4S is a touchscreen-based smartphone developed, manufactured, and released by Apple Inc. It is the fifth generation of the iPhone,[8] succeeding the iPhone 4 and preceding the iPhone 5. Announced on October 4, 2011 at Apple's Cupertino campus, its media coverage was accompanied by the death of former Apple CEO and co-founder Steve Jobs on the following day.";
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory; 

        public GSM (string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>(); 
        }

        public GSM(string model, string manufacturer, double price) : this (model,manufacturer)   
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, double price, string owner): this (model, manufacturer, price)
        {
            this.Owner = owner;
        }           

        public GSM(string model, string manufacturer, double price, string owner,Battery battery, Display display, List <Call> callHistory) : this (model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.display = display;
        }
       

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
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
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
        }

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

        public List<Call> AddCall (Call call)
        {
            this.callHistory.Add(call);
            return this.callHistory;
        }

        public List<Call> RemoveCall (Call call)
        {
            this.callHistory.Remove(call);
            return this.callHistory;
        }

        public List<Call> ClearCalls()
        {
            this.callHistory.Clear();
            return this.callHistory;
        }

        public decimal TotalCostOfCalls (decimal charge)
        {
            int callDuration = 0;
            for (int i = 0; i<this.callHistory.Count; i++)
            {
                callDuration += this.callHistory[i].Duration;
            }
            decimal result = callDuration * charge;
            return result;
        }

        public string PrintCallHistory()
        {
            return string.Format("Calls history:\n{0}", string.Join(Environment.NewLine, this.callHistory));
        }

        public override string ToString()
        {
            return this.model + "; " + this.manufacturer + "; " + this.price + "; " + this.owner + "; " + this.battery + " ;" + this.display;
        }

    }
}
