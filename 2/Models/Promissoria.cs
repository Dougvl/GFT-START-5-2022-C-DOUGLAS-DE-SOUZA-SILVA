using teste2.Interfaces;

namespace teste2.Models
{
    public class Promissoria : IRecebivel
    {
        public Promissoria(int prazoEmDias)
        {
            PrazoEmDias = prazoEmDias;
        }

        public int PrazoEmDias { get; set; }
        public double calcularValorRecebivel(double valor)
        {
            if(this.PrazoEmDias == 30)
            {
                return valor - valor*0.04;
            } 
            else if(this.PrazoEmDias ==60)
            {
                return valor - valor*0.065;
            }
            else if(this.PrazoEmDias == 90)
            {
                return valor - valor*0.085;
            }
            else if(this.PrazoEmDias > 90)
            {
                int tempo = (PrazoEmDias - 90)/ 30;
                double taxa = 0.085 + 0.02 * tempo;
                return valor - valor*taxa;
            }

            return -1;
        }
    }
}