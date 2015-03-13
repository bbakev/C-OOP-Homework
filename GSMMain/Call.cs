namespace GSMMain
{
    using System;

    public class Call
    {
        private DateTime date;
        private string dialedNumber;
        private int duration;

        public Call (DateTime date, string dialedNumber, int duration)
        {
            this.Date = date;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }
        
        public DateTime Date { get; set;}
        public string DialedNumber { get; set; }
        public int Duration { get; set; }

        public override string ToString()
        {
            return string.Format("Date and time: {0:G}; Number dialed: {1}; Call duration: {2}", this.Date, this.DialedNumber, this.Duration); 
        }
    }
}
