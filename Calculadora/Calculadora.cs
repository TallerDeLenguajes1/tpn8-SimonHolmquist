using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        private double numero1;
        private double numero2;
        private double resultado;
        private char operador;
        private DateTime hora;

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public char Operador { get => operador; set => operador = value; }
        public DateTime Hora { get => hora; set => hora = value; }

        public Calculadora()
        {
            Numero1 = -1D;
            Numero2 = -1D;
            Operador = ' ';
        }
        public double Suma()
        {
            return Numero1 + Numero2;
        }
        public double Resta()
        {
            return Numero1 - Numero2;
        }
        public double Multiplicacion()
        {
            return Numero1 * Numero2;
        }
        public double Division()
        {
            return Numero1 / Numero2;
        }

        public override string ToString()
        {
            return $"{Hora:dd/MM/yyyy hh:mm} {Numero1} {Operador} {Numero2} = {Resultado}";
        }
    }
}
