using AntDesignExample.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AntDesignExample.Model
{
    public class Timeframe
    {
        public enum DurationType
        {
            [Description("Millennium")]
            All = 0,

            [Description("24 Hours")]
            Last24Hours = 1,

            [Description("7 Days")]
            Last7Days = 7,

            [Description("30 Days")]
            Last30Days = 30,

            [Description("90 Days")]
            Last90Days = 90,

            [Description("365 Days")]
            Last365Days = 365
        }

        public DurationType Duration { get; set; }

        public string Name
        {
            get
            {
                return this.Duration.GetDescription();
            }
        }

        public DateTime FromDateAndTime
        {
            get
            {
                if (Duration == DurationType.All)
                {
                    return DateTime.MinValue;
                }

                return DateTime.UtcNow - TimeSpan.FromDays((double)Duration);
            }
        }

        public DateTime UntilDateAndTime
        {
            get
            {
                if (Duration == DurationType.All)
                {
                    return DateTime.MaxValue;
                }

                return DateTime.UtcNow;
            }
        }

        public static Timeframe[] Timeframes
        {
            get
            {
                return new Timeframe[] {
                    new Timeframe { Duration = DurationType.All },
                    new Timeframe { Duration = DurationType.Last24Hours },
                    new Timeframe { Duration = DurationType.Last7Days },
                    new Timeframe { Duration = DurationType.Last30Days },
                    new Timeframe { Duration = DurationType.Last90Days },
                    new Timeframe { Duration = DurationType.Last365Days }
                };
            }
        }
    }
}
