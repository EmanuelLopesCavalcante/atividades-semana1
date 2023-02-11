int f = 0;
int f1 = 1;
int F;
Console.Write("Sequência de fibonacci: ");
Console.Write( 1 + ", ");
for (int i = 0; i < 19; i++ ){
    F = f + f1;
    Console.Write($"{F}, ");
    f = f1;
    f1 = F;
}
Console.Write( 10946);
