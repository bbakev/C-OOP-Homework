namespace GSMMain
{

    using System;

    public class Battery
    {
        private double maxHoursIdle;
        private double maxHoursTalk;
        private TypesOfBattery batteryModel;

        public Battery(TypesOfBattery model, double maxHoursIdle, double maxHoursTalk)
        {
            this.batteryModel = model;
            this.MaxHoursIdle = maxHoursIdle;
            this.MaxHoursTalk = maxHoursTalk; 

        }

        public double MaxHoursIdle
        {
            get
            {
                return this.maxHoursIdle;
            }
            set
            {
                if (value > 500)
                {
                    throw new ArgumentOutOfRangeException("The maximum idle hours of a battery cannot exceed 500 minutes!");
                }
                this.maxHoursIdle = value;

            }
        }

        public double MaxHoursTalk
        {
            get
            {
                return this.maxHoursTalk;
            }
            set
            {
                if (value > 10)
                {
                    throw new ArgumentOutOfRangeException("The maximum hours of talk of a battery cannot exceed 10 hours!");
                }
                this.maxHoursTalk = value;

            }
        }

        public override string ToString()
        {
            return this.batteryModel.ToString() + " " + this.maxHoursIdle + " " + this.maxHoursTalk;
        }
    }
}
