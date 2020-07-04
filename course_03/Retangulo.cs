using System;
using System.Collections.Generic;
using System.Text;

namespace course_03 {
    class Retangulo {
        public double B;
        public double H;

        public double Area() {
            return B * H;
        }

        public double Perimetro() {
            return 2 * (B + H);
        }

        public double Diagonal() {
            return Math.Sqrt((Math.Pow(B, 2) + Math.Pow(H, 2)));
        }
    }
}
