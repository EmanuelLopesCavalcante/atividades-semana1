string nome;

Console.WriteLine("Você acabou de acessar o sistema de boletim 2.0; Para entrar digite seu nome completo:");
nome = Console.ReadLine();

int quantidade;

Console.WriteLine("Agora informe a quantidade de notas que quer colocar (informe apenas com números):");
while(!int.TryParse(Console.ReadLine(), out quantidade)){
    Console.WriteLine("só é possível colocar números. Tente novamente:");
}

double[] nota = new double [quantidade];
double soma = 0;

for ( int i = 0; i < quantidade; i++ ){
    Console.WriteLine("Coloque a " + (i+1) + " nota:");
    nota[i] = double.Parse(Console.ReadLine());
    soma += nota[i];
}

double media = soma / quantidade;
Console.WriteLine("------------");

Console.WriteLine("Aluno: " + nome);

for(int i = 0; i < quantidade; i++){
    Console.WriteLine("N"+(i+1)+": "+ nota[i]);
}

if (media >= 6){
    Console.WriteLine("Média: " + media + " -aprovado");
} else if ( media >= 5 && media < 6 ){
    Console.WriteLine("Média: " + media + " -recuperação");
} else if ( media < 5){
    Console.WriteLine("Média: " + media + " -reprovado");
}


