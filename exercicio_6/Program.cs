int numero;

Console.WriteLine("Digite um número inteiro para ser multiplicado pela tabauda de 10:");
while(!int.TryParse(Console.ReadLine(), out numero)){
    Console.WriteLine("Só pode número inteiro, não palavras cabeçudo(a)");
}

Console.WriteLine("-------------");

for(int baba = 0; baba < 11; baba++ ){
    Console.WriteLine($"{numero}x{baba} = {numero*baba}");
}




