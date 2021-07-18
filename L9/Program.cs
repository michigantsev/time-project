using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9
{
    class Program
    {
        static void Main(string[] args)
        {   
            Time t1 = new Time();            
            t1 = Time.ReadTime(t1);
            Time t2 = new Time();
            t2 = Time.ReadTime(t2);            
            Console.WriteLine("Часть 1:");
            t1.Show();
            t2.Show();
            Time t3 = Time.AddTime(t1, t2);            
            Console.Write("Сумма: ");
            t3.Show();            
            Time t4 = new Time();                       
            t4 = t1.AddTimeMethod( t2);                        
            Console.Write("Сумма: ");
            t4.Show();            
            Console.WriteLine($"Количество объектов: {Time.count}");
            Console.WriteLine();
            Console.WriteLine("Часть 2:");            
            t3++;                
            Console.Write("+1: ");
            t3.Show();                        
            t4--;
            Console.Write("-1: ");
            t4.Show();            
            int x = (int)t4;
            bool y = (bool)t4;
            Console.WriteLine($"int = {x}, bool = {y}");
            Console.WriteLine("Сумма: ");
            Time t5 = t3+t4;            
            t5.Show();
            Console.WriteLine("Сумма+20: ");
            t5 = t5 + 20;
            t5.Show();
            Console.WriteLine("40+сумма: ");
            t5 = 20 + t5;
            t5.Show();
            t5 = t1 - t2;
            Console.WriteLine("разность первых двух элементов: ");
            t5.Show();
            t5 = t1 - 20;
            Console.WriteLine("первый минус 20: ");
            t5.Show();
            Console.WriteLine("20 минус первый: ");
            t5 = 20-t1;
            t5.Show();
            Console.WriteLine();
            Console.WriteLine("Часть 3:");
            TimeArray ta = new TimeArray(5, true);            
            ta.ShowArray();
            double average = ta.Average();            
            Console.WriteLine("среднее значение: ");
            Console.WriteLine($"Часы: {(int)average/60}, Минуты: {average % 60}");
            Console.WriteLine("Введите массив: ");
            TimeArray ta1 = new TimeArray(5);
            double average1 = ta1.Average();
            ta1.ShowArray();    
            Console.WriteLine("среднее значение: ");
            Console.WriteLine($"Часы: {(int)average1 / 60}, Минуты: {average1 % 60}");
            TimeArray indexator = new TimeArray(2, true);
            indexator[0] = new Time(-5, -50);
            indexator[1] = new Time(6, 120);
            Console.WriteLine("индексатор:");
            indexator[0].Show();
            indexator[100].Show();
        }
    }
}
