using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_final_trilha_net_tests.models
{
     public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int v1, int v2) => ExecutarOperacao(v1, v2, (a, b) => a + b, "Soma");
        public int Subtrair(int v1, int v2) => ExecutarOperacao(v1, v2, (a, b) => a - b, "Subtração");
        public int Multiplicar(int v1, int v2) => ExecutarOperacao(v1, v2, (a, b) => a * b, "Multiplicação");
        public int Dividir(int v1, int v2)
        {
            if (v2 == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
            return ExecutarOperacao(v1, v2, (a, b) => a / b, "Divisão");
        }

        private int ExecutarOperacao(int v1, int v2, Func<int, int, int> operacao, string operacaoNome)
        {
            int resultado = operacao(v1, v2);
            AdicionarAoHistorico($"{operacaoNome} de {v1} e {v2} = {resultado}");
            return resultado;
        }

        private void AdicionarAoHistorico(string entrada)
        {
            listaHistorico.Insert(0, entrada);
            if (listaHistorico.Count > 3)
            {
                listaHistorico = listaHistorico.Take(3).ToList();
            }
        }

        public List<string> Historico()
        {
            return new List<string>(listaHistorico);
        }
    }
}