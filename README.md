# Projeto Prático Trilha .NET - DIO Pottencial

## Desafio Proposto

Utilizando os conhecimentos adquiridos no módulo **Explorando a Linguagem C#** da trilha .NET do bootcamp ***Pottencial .NET Developer***, desenvolver aplicativo de gerenciamento de Hóspedes e Reservas.

#

Criado um aplicativo console com o comando 
>***dotnet new console***

Conforme solicitado no projeto disponibilizado pelo professor [Leonardo Buta](https://github.com/digitalinnovationone/trilha-net-explorando-desafio/tree/main) foram criadas 3 classes com atributos:
* Pessoa (*nome e sobrenome*)
* Suíte (*tipo, capacidade e valor da diaria*)
* Reserva (*dias reservados*)

A classe ***Reserva*** recebe dois objetos: um do tipo **Lista** que contem objetos do tipo **Pessoa**  e outro objeto do tipo **Suite**. 

Nessa classe foram criados  4 métodos :
* *Cadastrar Hóspedes()*
* *Cadastrar Suítes()*
* *Obter Quantidade de Hóspedes()*
* *Calcular Valor da Diária()*

>* O método **Cadastrar Hospedes** tem uma validação que confere se a capacidade da suíte é menor que a quantidade de hóspedes cadastrados. Nesse caso lança uma ***Exception*** e encerra o programa.

>* O método **Calcular Valor da Diária** tem uma validação que concede um desconto no valor da diária caso os dias reservados sejam maior ou igual a 10 dias.

No método Principal foi configurado uma pequena interação com usuário que solicita os dados de cadastro da Suíte e em seguida é mostrado no console uma descrição da suite cadastrada junto com o valor da diária.

Após, é solicitado que sejam digitados os nomes dos hóspedes, informando ao usuário qual o comando de finalização do cadastro.

Caso esteja tudo de acordo com as regras de negócio do projeto, serão exibidos a quantidade de hóspedes cadastrados e o valor da diária, com uma personalização para exibir uma frase "*com desconto*" ou "*sem desconto*".

Projeto desenvolvido no Visual Studio Code com plugins [C# Microsoft](https://github.com/OmniSharp/omnisharp-vscode) e [C# Extensions by JosKreativ](https://github.com/kreativjos/csharpextensions).

Meu [Linkedin](https://www.linkedin.com/in/wesley-camelo-silva/).
