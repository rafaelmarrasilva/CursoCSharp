using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace course_03 {
    class ContaBancaria {
        double taxaOperacao = 5.0;
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular) {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular) {
            Deposito(saldo);
        }

        public void Deposito(double valor) {
            Saldo += valor - taxaOperacao;
        }

        public void Saque(double valor) {
            Saldo -= valor + taxaOperacao;
        }

        public override string ToString() {
            return "Conta " 
                + NumeroConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: $ "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
