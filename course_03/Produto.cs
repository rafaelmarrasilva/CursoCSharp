using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace course_03 {
    class Produto {
        private string _nome; //não aceita auto propriet pois criamos uma logica para ele
        public double Preco { get; private set; } //private é opcional
        public int Quantidade { get; private set; }

        public Produto() {

        }

        public Produto(string nome, double preco) {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1 ) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity) {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity) {
            Quantidade -= quantity;
        }

        public override string ToString() {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " 
                + Quantidade 
                + " unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
