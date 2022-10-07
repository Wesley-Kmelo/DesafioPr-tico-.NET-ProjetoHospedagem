
using DesafioPrático_.NET_ProjetoHospedagem.Models;

//Primeiro criar lista desejada. Depois criar os objetos que vão popular essa lista
//No método Add , adicionar esses objetos e não as strings

List<Pessoa> hospedes = new List<Pessoa>();

// Pessoa p1 = new Pessoa("Hospede","etste");
// Pessoa p2 = new Pessoa("Teste");
// Pessoa p3 = new Pessoa("RS");

// hospedes.Add(p1);
// hospedes.Add(p2);
// hospedes.Add(p3);

//pequena interação com usuario pára criação de suite e quantidade de dias
Console.WriteLine("Criação da SUíTE");
Console.Write("Tipo da Suíte => ");
string tipo = Console.ReadLine();
Console.Write("Capacidade da Suíte => ");
int capacidade = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor da Diária da Suíte => ");
decimal diaria = Convert.ToDecimal(Console.ReadLine());

Console.Write("Reservar Suíte por quantos dias => ");
int qtdReserva = Convert.ToInt32(Console.ReadLine());

Suite suite = new Suite(tipo, capacidade, diaria);
Reserva reserva = new Reserva(qtdReserva);

Console.WriteLine(suite.DescritivoSuite);

//pequena interação com usuario, permitindo adicionar quantos hospedes quiser.
bool sair = false;
Console.WriteLine("\nDigite o nome dos Hóspedes...");
Console.WriteLine("Para finalizar digite \"sair\""); 

while (!sair)
{
   Console.Write("=> ");
   string hospede = Console.ReadLine();
   if (hospede!= "sair")
   {
      Pessoa p = new Pessoa(hospede);
      hospedes.Add(p);      
   }
   else
   {
      sair = true; 
      Console.Clear();     
   }
}

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

string pessoa = "";
string desconto ="";
string dias = "";
pessoa = hospedes.Count>1? "pessoas":"pessoa";
desconto = reserva.DiasReservados>=10 ? "com desconto": "sem desconto";
dias = reserva.DiasReservados<=1 ? "dia": "dias";


Console.WriteLine($"A quantidade de Hospedes é de {reserva.ObterQuantidadeHospedes()} {pessoa}.");
Console.WriteLine($"Valor total dessa Reserva {desconto} para {reserva.DiasReservados} {dias} é de R$ {reserva.CalcularValorDiaria()}.");