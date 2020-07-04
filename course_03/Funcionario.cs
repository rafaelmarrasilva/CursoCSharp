using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace course_03 {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario( double perc) {
            SalarioBruto += ((SalarioBruto * perc)/100);
        }

        public override string ToString() {
            return Nome 
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
