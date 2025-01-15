using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Part02
{
    internal class Duration
    {
        #region 1.Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

        #region Full Properties
        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        private int minutes;

        public int Minutes
        {
            get { return minutes; }
            set
            {
                minutes = value;
                while (minutes >= 60)
                {
                    hours += minutes / 60;

                    minutes %= 60; // minutes = minutes % 60
                }
            }
        }

        private int seconds;

        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = value;
                while (seconds >= 60)
                {
                    minutes += seconds / 60;

                    seconds %= 60;
                }

                while (minutes >= 60)
                {
                    hours += minutes / 60;

                    minutes %= 60; // minutes = minutes % 60
                }
            }
        }

        #endregion

        #region Constructors
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration()
        {
            hours = seconds = seconds = 0;
        }

        public Duration(int seconds)
        {
            Seconds = seconds;
        }

        #endregion

        #endregion

        #region 2.Override All System.Object Members (ToString, Equals, GetHasCode) .

        public override string ToString()
        {
            if (hours != 0)
                return $"Hours:{hours}, Minutes:{minutes}, Seconds{seconds}";
            else if (minutes != 0)
                return $"Minutes:{minutes}, Seconds{seconds}";
            else
                return $"Seconds{seconds}";

        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Duration d = (Duration)obj;
                return (hours == d.hours && minutes == d.minutes && seconds == d.seconds);
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ hours + minutes + seconds;

            //return HashCode.Combine(hours, minutes, seconds);
        }

        #endregion

        #region 3.Define All Required Constructors to Produce this output:

        //Try in Main() --->

        #endregion

        #region 4.Implement All required Operators overloading’s to enable this Code:

        #region D3=D1+D2

        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) + (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) + (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) + (right?.Seconds ?? 0)
            };
        }

        #endregion

        #region D3 = D1 + 7800
        public static Duration operator +(Duration left, int right)

        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) + (right / 3600),
                Minutes = (left?.Minutes ?? 0) + (right % 3600 / 60),
                Seconds = (left?.Seconds ?? 0) + (right % 3600 % 60)
            };
        }
        #endregion

        #region D3=666+D3
        public static Duration operator +(int left, Duration right)
        {
            return new Duration()
            {
                Hours = (left / 3600) + (right?.Hours ?? 0),
                Minutes = (left % 3600 / 60) + (right?.Minutes ?? 0),
                Seconds = (left % 3600 % 60) + (right?.Seconds ?? 0)
            };
        }
        #endregion

        #region D3 = ++D1(Increase One Minute)
        public static Duration operator ++(Duration d)
        {
            return new Duration()
            {
                Hours = d?.Hours ?? 0,
                Minutes = (d?.Minutes ?? 0) + 1,
                Seconds = d?.Seconds ?? 0
            };
        }
        #endregion

        #region D3 = --D2(Decrease One Minute)

        public static Duration operator --(Duration d)
        {

            if (d.minutes == 0 && d.Hours != 0)
            {
                return new Duration()
                {
                    Hours = (d?.Hours ?? 0) - 1,
                    Minutes = 59,
                    Seconds = d?.Seconds ?? 0
                };
            }
            else
            {

                return new Duration()
                {
                    Hours = d?.Hours ?? 0,
                    Minutes = (d?.Minutes ?? 0) - 1,
                    Seconds = d?.Seconds ?? 0
                };
            }
        }


        #endregion

        #region If(D1>D2) 
        public static bool operator >(Duration left, Duration right)
        {
            return (left.hours > right.hours)
                || (left.hours == right.Hours && left.minutes > right.minutes)
                || (left.hours == right.Hours && left.minutes == right.minutes && left.seconds > right.seconds);
        }

        public static bool operator <(Duration left, Duration right)
        {
            return (left.hours < right.hours)
                || (left.hours == right.Hours && left.minutes < right.minutes)
                || (left.hours == right.Hours && left.minutes == right.minutes && left.seconds < right.seconds);
        }

        #endregion

        #region D1= D1 - D2
        public static Duration operator -(Duration left, Duration right)
        {
            if (left > right)
            {
                int seconds;
                seconds = ((left.Hours * 3600) + (left.minutes * 60) + (left.seconds)) - ((right.Hours * 3600) + (right.minutes * 60) +
                    (right.seconds));

                return new Duration(seconds);
            }
            else
            {
                return new Duration();
            }

        }

        #endregion

        #region If(D1<=D2)
        public static bool operator <=(Duration left, Duration right)
        {
            return ((left.Hours * 3600) + (left.minutes * 60) + (left.seconds)) <= ((right.Hours * 3600) + (right.minutes * 60) +
                    (right.seconds));

        }

        public static bool operator >=(Duration left, Duration right)
        {
            return ((left.Hours * 3600) + (left.minutes * 60) + (left.seconds)) >= ((right.Hours * 3600) + (right.minutes * 60) +
                    (right.seconds));

        }

        #endregion

        #region If(D1)
        public static bool operator true(Duration D)
        {
            return (D.hours != 0 || D.minutes != 0 || D.seconds != 0);
        }

        public static bool operator false(Duration D)
        {
            return (D.hours == 0 || D.minutes == 0 || D.seconds == 0);
        }

        #endregion

        #region DateTime Obj = (DateTime)D1
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(2023, 3, 7, d.Hours, d.minutes, d.seconds);
        }

        #endregion

        #endregion
    }
}
    
