using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Matematica(int n1, int n2)
    {
        private readonly int num1 = n1;
        private readonly int num2 = n2;

        public int Somar(){
            return this.num1 + this.num2;
        }

        public int Subtrair(){
            return this.num1 - this.num2;
        }

        public int Multiplicar(){
            return this.num1 * this.num2;
        }

        public int Dividir(){
            if(this.num2 == 0){
                throw new DivideByZeroException("Não pode dividir por 0");
            }
            return this.num1 / this.num2;
        }

    }
}