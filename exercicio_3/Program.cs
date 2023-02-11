double nota1;
double nota2;
double nota3;
double media;
Console.WriteLine("Insira sua nota do primeiro trimestre: ");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira sua nota do segundo trimestre: ");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira sua nota do terceiro trimestre: ");
nota3 = double.Parse(Console.ReadLine());
media = (nota1 + nota2 + nota3) / 3;
if (media >= 6){
    Console.WriteLine("aluno aprovado com " + media ); 
} if (media >= 5 && media < 6){
    Console.WriteLine("Aluno em recuperação com média: " + media);
} if (media < 5){
    Console.WriteLine("Aluno reprovado com média: " + media);
};

