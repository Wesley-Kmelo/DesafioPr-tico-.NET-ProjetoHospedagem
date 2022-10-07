using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPrático_.NET_ProjetoHospedagem.Models
{
    public class Suite
    {

        public Suite(){}
        public Suite (string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite {get; set;}
        public int Capacidade {get; set;}
        public decimal ValorDiaria {get; set;}
        public string pessoa
        {
            get
            {
                if (Capacidade < 2)
                {
                    return "pessoa";
                }
                return "pessoas";
            }
        }

        public string DescritivoSuite 
        {
            get
            {
                if (TipoSuite != null || Capacidade<1 || ValorDiaria<0)
                {
                 return $"A suíte \"{TipoSuite}\" tem capacidade para {Capacidade} {pessoa} e sua diária é no valor de R$ {ValorDiaria}";
                }                
                else
                {
                    throw new Exception ("Parâmetros da Suíte incorretos");
                }
            }
        }
    }
}