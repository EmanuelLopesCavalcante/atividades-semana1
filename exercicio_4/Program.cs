double salario;
Console.WriteLine("Digite seu salário bruto para o cálculo de imposto:");
salario = double.Parse(Console.ReadLine());
if (salario <= 900){
    Console.WriteLine("Sem descontos.");
} if (salario > 900 && salario <= 1500){
    Console.WriteLine( "R$" + salario/100 * 5 + " de desconto.");
} if (salario > 1500 && salario <= 2500){
    Console.WriteLine($"R${salario/100 * 10} de desconto");
} if (salario > 2500){
    Console.WriteLine($"R${salario / 100 * 20} de dsconto");
}