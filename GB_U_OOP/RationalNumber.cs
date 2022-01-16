using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_U_OOP
{
    public partial class RationalNumber
    {
        private int _numerator;
        private int _denominator;

        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }


        public int Numerator
        {
            get => _numerator;
            set => _numerator = value;
        }

        public int Denominator
        {
            get => _denominator;
            set => _denominator = value;
        }

        public override string ToString()
        {
            return _numerator.ToString() + "/" + _denominator.ToString();
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            RationalNumber t = new RationalNumber(1, 1);
            t.Numerator = (a.Numerator * b.Denominator + a.Denominator * b.Numerator);
            t.Denominator = a.Denominator * b.Denominator;

            return SetFormat(t);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            RationalNumber t = new RationalNumber(1, 1);
            t.Numerator = a.Numerator * b.Denominator - a.Denominator * b.Numerator;
            t.Denominator = a.Denominator * b.Denominator;
            return SetFormat(t);
        }

        public static RationalNumber operator --(RationalNumber a)
        {
            RationalNumber counter = new RationalNumber(1, 1);
            return SetFormat(a - counter);
        }

        public static RationalNumber operator ++(RationalNumber a)
        {
            RationalNumber counter = new RationalNumber(1, 1);
            return SetFormat(a + counter);
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            RationalNumber t = new RationalNumber(1, 1);
            t.Numerator = a.Numerator * b.Numerator;
            t.Denominator = a.Denominator * b.Denominator;
            return SetFormat(t);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b) 
        {
            RationalNumber t = new RationalNumber(1, 1);
            t.Numerator = a.Numerator / b.Numerator; 
            t.Denominator = a.Denominator / b.Denominator;
            return SetFormat(t); 
        }

        public static bool operator >(RationalNumber n1, RationalNumber n2)
        {
            double num1 = ((double)n1.Numerator / (double)n1.Denominator);
            double num2 = ((double)n2.Numerator / (double)n2.Denominator);

            return (num1 > num2);
        }

        public static bool operator <(RationalNumber n1, RationalNumber n2)
        {
            double num1 = ((double)n1.Numerator / (double)n1.Denominator);
            double num2 = ((double)n2.Numerator / (double)n2.Denominator);

            return (num1 < num2);
        }

        public static bool operator >=(RationalNumber n1, RationalNumber n2)
        {
            double num1 = ((double)n1.Numerator / (double)n1.Denominator);
            double num2 = ((double)n2.Numerator / (double)n2.Denominator);

            return (num1 >= num2);
        }

        public static bool operator <=(RationalNumber n1, RationalNumber n2)
        {
            double num1 = ((double)n1.Numerator / (double)n1.Denominator);
            double num2 = ((double)n2.Numerator / (double)n2.Denominator);

            return (num1 <= num2);
        }

        public static bool operator ==(RationalNumber n1, RationalNumber n2)
        {
            double num1 = ((double)n1.Numerator / (double)n1.Denominator);
            double num2 = ((double)n2.Numerator / (double)n2.Denominator);

            return (num1 == num2);
        }

        public static bool operator !=(RationalNumber n1, RationalNumber n2)
        {
            double num1 = ((double)n1.Numerator / (double)n1.Denominator);
            double num2 = ((double)n2.Numerator / (double)n2.Denominator);

            return (num1 != num2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            RationalNumber n1 = (RationalNumber)obj;

            double num1 = ((double)n1.Numerator / (double)n1.Denominator);
            double num2 = (double) (_numerator / (double) _denominator);
            return (num1 == num2);
        }

        public override int GetHashCode()
        {
            return _numerator ^ _denominator;
        }

        private static RationalNumber SetFormat(RationalNumber a)
        {
            int max = 0;
            
            if (a.Numerator > a.Denominator)
                max = Math.Abs(a.Denominator);
            else
                max = Math.Abs(a.Numerator);

            for (int i = max; i >= 2; i--)
            {
                if ((a.Numerator % i == 0) & (a.Denominator % i == 0))
                {
                    a.Numerator /=  i;
                    a.Denominator /= i;
                }
            }

            if ((a.Denominator < 0))
            {
                a.Numerator = -1 * (a.Numerator);
                a.Denominator = Math.Abs(a.Denominator);
            }

            return (a);
        }
    }
}