using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPrático_.NET_ProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite SuiteReserva {get; set;}
        public int DiasReservados{get; set;}

        public Reserva (){}

        public Reserva (int dias)
        {
            DiasReservados = dias;
        }


        public void CadastrarHospedes(List<Pessoa>hospedes)
        {            
            if (SuiteReserva.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;                
            }
            else
            {
                throw new Exception("A capacidade de Hóspedes supera a capacidade da Suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            SuiteReserva = suite;
        }

        public int ObterQuantidadeHospedes(){
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal total = DiasReservados * SuiteReserva.ValorDiaria;
            if (DiasReservados >= 10)
            {
                total = total * 0.10M;
            }
            return total;
        }
    }
}