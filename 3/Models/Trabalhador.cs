using System.Collections.Generic;

namespace Exercicio3
{
    public class Trabalhador
    {
        private string nome;
        private double salarioPorHora;
        private int horasTrabalhadas;
        

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string value)
        {
            nome = value;
        }

        public int GetHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }

        public void SetHorasTrabalhadas(int value)
        {
            horasTrabalhadas = value;
        }

        public double GetSalarioPorHora()
        {
            return salarioPorHora;
        }

        public void SetSalarioPorHora(double value)
        {
            salarioPorHora = value;
        }

        public double GetSalarioTotal()
        {
            return GetSalarioPorHora() * GetHorasTrabalhadas();
        }
    }
}