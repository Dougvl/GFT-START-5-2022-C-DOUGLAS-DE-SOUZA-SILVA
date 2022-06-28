using teste2.Interfaces;

namespace teste2.Models
{
    public class Cheque : IRecebivel
    {
        public Cheque(int prazoEmDias)
        {
            this.PrazoEmDias = prazoEmDias;
        }

        public int PrazoEmDias { get; set; }
        public double calcularValorRecebivel(double valor)
        {
            if (this.PrazoEmDias == 30)
            {
                return valor - valor * 0.05;
            }
            else if (this.PrazoEmDias == 60)
            {
                return valor - valor * 0.075;
            }
            else if (this.PrazoEmDias == 90)
            {
                return valor - valor * 0.010;
            }
            else if (this.PrazoEmDias > 90)
            {
                int tempo = (PrazoEmDias - 90) / 30;
                double taxa = 0.10 + 0.03 * tempo;
                return valor - valor * taxa;
            }

            return -1;
        }
    }
}