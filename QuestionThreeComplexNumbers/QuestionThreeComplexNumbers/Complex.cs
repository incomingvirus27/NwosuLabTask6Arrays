using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionThreeComplexNumbers
{
    class Complex
    {

        public float real;
        public float imaginary;

        public Complex(float real, float imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public Complex()
        {

        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
        }

        public override string ToString()
        {
            return string.Format("{0:f} + {1:f}i", real, imaginary);
        }
    }
}
