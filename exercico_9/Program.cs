Console.WriteLine("Bem vindo ao Banco Nacional dos Coqueiros, por favor selecione uma opção para continuar:");

int opcao;
double valor = 0.00;
List<double> valor2 = new List<double>();

do{
    Console.WriteLine("1. Adicionar uma transação;");
    Console.WriteLine("2. Consultar extrato;");
    Console.WriteLine("3. Sair;");
    while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3) {
        Console.WriteLine("Número inválido. Tente novamente:");
    }
    
    if (opcao == 1){
    Console.WriteLine("Informe o valor da transação:");
    valor = double.Parse(Console.ReadLine());
    valor2.Add(valor);
} else if (opcao == 2){
    Console.WriteLine("------------------------");
    Console.WriteLine("Historico de transações:");
    foreach(double i in valor2){
        Console.WriteLine(i);
    }
    double soma = valor2.Sum();
    Console.WriteLine("Saldo: " + soma);
    Console.WriteLine("Aperte enter para retornar");
    Console.ReadLine();
}

} while (opcao != 3);

Console.WriteLine("Fim do programa.");

