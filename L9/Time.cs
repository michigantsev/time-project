using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9
{
    public class Time
    {
        public static int count = 0;
        int hours;
        int minutes;        

        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0)
                {
                    hours = 0;
                }

                hours = value;
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value < 0)
                {
                    minutes = 60 + value;
                    Hours -= 1;
                }
                else if (value <= 0 && Hours <= 0)
                {
                    hours = 0;
                    minutes = 0;
                }
                else if (value > 59)
                {
                    Hours += value / 60;
                    minutes = value % 60;
                }
                else
                    minutes = value;
            }
        }

        public Time(int a, int b)
        {
            count++;
            Hours = a;
            Minutes = b;
        }        

        public Time()
        {
            count++;
            Hours = 0;
            Minutes = 0;
        }

        public void Show()
        {
            Console.WriteLine($"Часы: {hours}, минуты: {minutes}");
        }

        public static Time AddTime(Time t1, Time t2)
        {
            Time temp = new Time();
            temp.Hours = t1.hours + t2.hours;
            temp.Minutes = t1.minutes + t2.minutes;
            return temp;
        }

        public Time AddTimeMethod( Time t2)
        {
            Time temp = new Time();
            temp.Hours = this.hours + t2.hours;
            temp.Minutes = this.minutes + t2.minutes;
            return temp;
        }

        public static Time operator ++(Time t)
        {
            t.Minutes++;
            return t;
        }

        public static Time operator --(Time t)
        {
            if (t.Minutes == 0)
            {
                if (t.Hours > 0)
                {
                    t.Hours--;
                    t.Minutes = 59;
                }
                else
                {
                    t.Hours = 0;
                    t.Minutes = 0;
                }
            }
            else t.Minutes--;
            return t;
        }

        public static explicit operator int (Time t)
            {
            return t.hours;
            }

        public static implicit operator bool (Time t)
        {
            if (t.minutes > 0 && t.hours > 0)
                return true;
            else return false;
        }

        public static Time operator +(Time t1, Time t2)
        {
            Time res = new Time();
            res.Hours = t1.Hours + t2.Hours;
            res.Minutes = t1.Minutes + t2.Minutes;
            return res;
        }

        public static Time operator -(Time t1, Time t2)
        {
            Time res = new Time();
            if (t1.Hours*60+t1.Minutes >= t2.Hours*60 + t2.Minutes)
            {
                res.Hours = t1.Hours - t2.Hours;
                res.Minutes = t1.Minutes - t2.Minutes;
            }
            return res;
        }
        public static Time operator +(Time t1, int t2)
        {
            Time res = new Time();
            res.Hours = t1.Hours;
            res.Minutes = t1.Minutes + t2;
            return res;
        }
        public static Time operator +(int t2,Time t1 )
        {
            Time res = new Time();
            res.Hours = t1.Hours;
            res.Minutes = t1.Minutes + t2;
            return res;
        }
        public static Time operator -(Time t1, int t2)
        {
            Time res = new Time();
            if (t1.Hours * 60 + t1.Minutes >= t2)
            {
                res.Hours = t1.Hours;
                res.Minutes = t1.minutes - t2;
            }
            return res;
        }
        public static Time operator -(int t2, Time t1)
        {
            Time res = new Time();
            if (t2 >= t1.Hours * 60 + t1.Minutes)
            {
                res.Hours = t1.Hours;
                res.Minutes = t1.Minutes - t2;
            }
            return res;
        }
        public static Time ReadTime(Time t)
        {
            bool ok = true;
            do
            {
                try
                {
                    Console.WriteLine("Введите часы:");
                    t.Hours = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                    ok = false;
                }
            } while (!ok || t.Hours < 0);
            do
            {
                Console.WriteLine("Введите минуты: ");
                try
                {
                    t.minutes = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                    ok = false;
                }
            } while (!ok || t.minutes < 0 || t.minutes > 60);
            return t;
        }
    }
}
