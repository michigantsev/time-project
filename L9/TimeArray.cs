using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9
{
    public class TimeArray
    {
        Time[] arr;        
        public Time this[int index]
        {
            get {
                if (index < arr.Length)
                    return arr[index];
                else
                {
                    Console.WriteLine("Неверный индекс");
                    Time t = new Time(0, 0);
                    return t;
                }                
                }
            set { if (value.Hours>-1 && value.Minutes>-1)
                    arr[index] = value;
                else
                    arr[index] = new Time(0, 0);
                }
        }
    public TimeArray()
        {
            Time[] arr = new Time[0];
        }
        public TimeArray(int size, bool ok)
        {
            arr = new Time[size];
            Random a = new Random(0);
            for (int i = 0; i < size; i++)
            {
                
                arr[i] = new Time();
                arr[i].Hours = a.Next(0, 100);
                arr[i].Minutes = a.Next(0, 60);
            }
        }
        public TimeArray(int size)
        {
            arr = new Time[size];
            bool ok = false;
            for (int i = 0; i < size; i++)
            {                
                    arr[i] = new Time();
                    arr[i] = Time.ReadTime(arr[i]);                 
            }
            
        }
        public void ShowArray()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i].Show();
        }
        public double Average()
        {
            double sumHours = 0.0;
            Time result = new L9.Time();
            for (int i = 0; i < arr.Length; i++)
                result += arr[i];            
            sumHours = result.Hours * 60 + result.Minutes;
            return sumHours/arr.Length;
        }        
    }
}
