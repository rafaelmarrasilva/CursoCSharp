using System;
using System.Collections.Generic;
using System.Text;

namespace course_03 {
    class Calculadora {

        public static double Pi = 3.14;

        public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }

        //metodo que receber N parametros...
        public static int Sum(params int[] numbers) {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        ////Modificador de parametro REF -- não utilizar
        public static void TripleRef(ref int x) {
            x = x * 3;
        }

        //Modificador de parametro OUT -- não utilizar
        public static void TripleOut(int origin, out int result) {
            result = origin * 3;
        }


    }
}
