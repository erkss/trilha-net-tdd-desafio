using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> listaHistorico;
        private string data;

        public CalculadoraImp(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2)
        {
            listaHistorico.Insert(0, $"Res: {val1 + val2}, Data: {data}");
            return val1 + val2;
        }

        public int subtrair(int val1, int val2)
        {
            listaHistorico.Insert(0, $"Res: {val1 - val2}, Data: {data}");
            return val1 - val2;
        }

        public int multiplicar(int val1, int val2)
        {
            listaHistorico.Insert(0, $"Res: {val1 * val2}, Data: {data}");
            return val1 * val2;
        }

        public int dividir(int val1, int val2)
        {
            listaHistorico.Insert(0, $"Res: {val1 / val2}, Data: {data}");
            return val1 / val2;
        }

        public List<String> historico()
        {
           listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
           return listaHistorico;
        }
    }
}