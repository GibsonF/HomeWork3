using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionClass
{
    public class MyClass
    {
    }

    public class Complex
    {
        private double im;
        private double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double re, double im)
        {            
            this.im = im;
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public Complex Minus(Complex x)
        {
            Complex NewX = new Complex();
            NewX.im = im - x.im;
            NewX.re = re - x.re;
            return NewX;
        }
        public Complex Multi(Complex x)
        {
            Complex NewX = new Complex();
            NewX.re = (x.re * this.re)-(x.im*this.im);
            NewX.im = this.re * x.im + x.re * this.im;
            return NewX;
        }
        public double Im
        {
            get { return im; }
            set
            {
               im = value;
            }
        }
        public double Re
        {
            get { return re; }
            set
            {
                re = value;
            }
        }
        // Специальный метод, который возвращает строковое представление данных.
        public string Tostring()
        {
            return re + "+" + im + "i";
        }
    }
    public class Fraction
    {
        private int numinator;
        private int denominator;
        public Fraction()
        {
            numinator = 1;
            denominator = 1;
        }
        public Fraction(int numinator,int denominator)
        {
            
                try
                {
                    if (denominator == 0) throw new ArgumentException();
                    this.numinator = numinator;
                    this.denominator = denominator;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
        }

        public int Numinator
        {
            get { return numinator; }
            set { numinator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public double DecFrac
        {
            get
            {
                return numinator / denominator;
            }
        }

        public Fraction Plus(Fraction x)
        {
            Fraction y = new Fraction();
            y.Denominator = this.denominator * x.Denominator;
            y.Numinator = this.denominator * x.Numinator + this.numinator * x.Denominator;
            y = Simplify(y);
            return y;
        }

        public Fraction Minus(Fraction x)
        {
            Fraction y = new Fraction();
            y.Denominator = this.denominator * x.Denominator;
            y.Numinator =   this.numinator * x.Denominator- this.denominator * x.Numinator;
            y = Simplify(y);
            return y;
        }

        public Fraction Multi(Fraction x)
        {
            return Simplify(new Fraction(this.numinator * x.Numinator, this.denominator * x.Denominator));
        }

        public Fraction Div(Fraction x)
        {
            return Simplify(new Fraction(this.numinator * x.Denominator, this.denominator * x.Numinator));
        }

        public static Fraction Simplify(Fraction x)
        {
            Fraction y = new Fraction(x.Numinator, x.Denominator);
            int max,maxdiv=-1;
            max= (y.Numinator > y.Denominator ? max = y.Numinator : max = y.Denominator);
            while (true){
                maxdiv = -1;
                for (int i = 1; i <= max; i++)
                {
                    if(y.Numinator % i==0&&y.Denominator % i==0)
                    {
                        if (i >= maxdiv) maxdiv = i; 
                    }
                }
                if (maxdiv == 1) break;
                else
                {
                    y.Numinator /= maxdiv;
                    y.Denominator /= maxdiv;
                }
                max = (y.Numinator > y.Denominator ? max = y.Numinator : max = y.Denominator);

            }
            return y;
        }
        public string Tostring()
        {
            return numinator + "/" + denominator;
        }
    }
}
