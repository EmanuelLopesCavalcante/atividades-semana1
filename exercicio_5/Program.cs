int valor1;
int valor2;
int valor3;
Console.WriteLine("Coloque um valor para um lado do triângulo:");
valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("Agora coloque um segundo valor para o segundo lado do triângulo:");
valor2 = int.Parse(Console.ReadLine());
Console.WriteLine("Por fim, informe o último valor para o terciro lado do triângulo: ");
valor3 = int.Parse(Console.ReadLine());
if(valor1 + valor2 > valor3  || valor3 + valor2 > valor1  || valor3 + valor1 > valor2){
    if ( valor1 == valor2 && valor2 == valor3 ){
    Console.WriteLine("Esse triângulo é equilátero");
} else if ( valor1 == valor2  || valor2 == valor3  || valor3 == valor1){
    Console.WriteLine("Esse é um triângulo isóceles");
} else if (valor1 != valor2 && valor2 != valor3 && valor3 != valor1){
    Console.WriteLine("Esse é um triângulo escaleno");
}
} else {
    Console.WriteLine("Isto não é um triângulo");
};