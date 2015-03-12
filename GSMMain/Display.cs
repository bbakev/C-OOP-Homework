namespace GSMMain
{
    public class Display
    {
        private double displayHeight;
        private double displayWidth;
        private int numberOfColors;

        public Display(double displayHeight, double displayWidth, int colors)
        {
            this.displayHeight = displayHeight;
            this.displayWidth = displayWidth;
            this.numberOfColors = colors;
        }

        public double DisplayHeight { get; set;}
        public double DisplayWidth { get; set; }
        public int NumberOfColors { get; set; }

        public override string ToString()
        {
            return this.displayHeight + " " + this.displayWidth + " " + this.numberOfColors;        
        }
    }
}
