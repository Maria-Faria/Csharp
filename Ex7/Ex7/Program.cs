/*Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, 
 * número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.*/

Console.WriteLine("""
        
    ░░███╗░░░░░
    ░████║░░░░░
    ██╔██║░░░░░
    ╚═╝██║░░░░░
    ███████╗██╗
    ╚══════╝╚═╝
    """);

Console.WriteLine();
Titular titular = new Titular();
titular.Name = "Maria Eduarda de Faria";

Conta conta = new Conta();
conta.titular = titular;
conta.Agencia = "Agencia 1";
conta.Saldo = 1400;
conta.Numero = 1;

conta.informacoes();


