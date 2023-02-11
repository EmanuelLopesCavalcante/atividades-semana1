int base1;
int altura;
int area;
Console.WriteLine("Aqui nos vamos relizar a area de um triangulo, primeiro escolha um valor para a base:" );
base1 = int.Parse(Console.ReadLine());
Console.WriteLine("Agora escolha a altura:");
altura = int.Parse(Console.ReadLine());
area = (base1 * altura)/2;
Console.WriteLine("A area do triangulo é: " + area);