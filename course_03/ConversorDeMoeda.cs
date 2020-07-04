using System;
using System.Collections.Generic;
using System.Text;

namespace course_03 {
    class ConversorDeMoeda {
        public static double Iof = 0.06;

        public static double Conversor(double cotacao, double valor) {
            double t = cotacao * valor;
              return t += (t * Iof);
        }
    }
}
