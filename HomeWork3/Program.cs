using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdditionClass;

namespace HomeWork3
{
    class Program
    {
         

    struct Complexs
    {
        public double im;
        public double re;
           
        public Complexs Plus(Complexs x)
        {
            Complexs y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complexs Minus(Complexs x)
        {
                Complexs NewY;
                NewY.im = im - x.im;
                NewY.re = re - x.re;
                return NewY;
        }
        public Complexs Multi(Complexs x)
        {
            Complexs y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string Tostring()
        {
            return re + "+" + im + "i";
        }
    }

        public static void FirstTask()
        {
            Complexs xs, ys;
            xs.im = 4;
            xs.re = 3;
            ys.re = 4;
            ys.im = 3;
            Complex x = new Complex(3, 4);
            Complex y = new Complex(4, 3);
            Console.WriteLine("Представление комплЕксных чисел: re+ i*im");
            Console.WriteLine("пункт А, задание 1 (структура Complex)");
            Console.WriteLine("Есть два комплексных числа: x=3+4i и y=4+3i.\nПроведем операции: x-y. Должно получиться -1 + 1i.");
            Console.WriteLine(xs.Minus(ys).Tostring());
            Console.WriteLine("пункт Б, задание 1 (класс Complex)");
            Console.WriteLine("Есть два комплексных числа: x=3+4i и y=4+3i.\nПроведем операции: x*y+x-y. Должно получиться -1 + 26i.");
            Console.WriteLine(x.Multi(y).Plus(x).Minus(y).Tostring());
            Console.WriteLine("пункт В, задание 1 (класс Complex+switch)");
            string i = "1";
            Complex z = new Complex();
            Complex buf;
            while (i != "0")
            {
                Console.WriteLine("1-задать начальное число(сначала re, потом im)\n2-прибавить к текущему числу новое(ввести новое число)\n3-вычесть из текущего числа новое(ввести новое число)\n4-умножить текущее число н новое(ввести новое число)\n0-выйти");
                i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        z = new Complex(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        break;
                    case "2":
                        buf = new Complex(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        z = z.Plus(buf);
                        break;
                    case "3":
                        buf = new Complex(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        z = z.Minus(buf);
                        break;
                    case "4":
                        buf = new Complex(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        z = z.Multi(buf);
                        break;
                    case "0":
                        Console.WriteLine("Финальный результат: " + z.Tostring());
                        break;
                }
                if (i != "0") Console.WriteLine("Результат: " + z.Tostring());
            }
            Console.ReadKey();
        }
        public static void ThirdTask()
        {
            string i = "1";
            Fraction f=new Fraction();
            while (i != "0")
            {
                Console.WriteLine("1-задать начальное число(сначала числитель, потом делитель)\n2-прибавить к текущему числу новое(ввести новое число)\n3-вычесть из текущего числа новое(ввести новое число)\n4-умножить текущее число н новое(ввести новое число)\n5-упростить дробь(введите новую)\n0-выйти");
                i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        f = new Fraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                        f=Fraction.Simplify(f);
                        break;
                    case "2":
                        f = f.Plus(new Fraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                        break;
                    case "3":
                        f = f.Minus(new Fraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                        break;
                    case "4":
                        f = f.Multi(new Fraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                        break;
                    case "5":
                        Fraction.Simplify(f).Tostring();
                        break;
                    case "0":
                        Console.WriteLine("Финальный результат: " + f.Tostring());
                        break;
                }
                if (i != "0") Console.WriteLine("Результат: " + f.Tostring());
            }
            Console.ReadKey();
        }
    static void Main(string[] args)
        {
            string i = "1";
            while (i != "0")
            {
                Console.WriteLine("1-первое задание. 3-третье задание");
                 i = Console.ReadLine();
                switch (i)
                {
                    case "1": FirstTask(); break;
                    case "3": ThirdTask(); break;
                }
            }
               
            Console.ReadKey();
        }


    }
}
