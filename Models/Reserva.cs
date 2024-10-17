namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if(Suite == null)
            {
                throw new InvalidOperationException("A suíte não foi cadastrada.");
            }
            else if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A quantidade de hóspedes é maior que a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        
        //TODO Corrigir
        public decimal CalcularValorDiaria()
        {
            decimal valor;

            if (DiasReservados >= 10) 
            {
                valor = Suite.ValorDiaria - Suite.ValorDiaria * 0.10m;;
            }
            else
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }

            return valor;
        }
    }
}