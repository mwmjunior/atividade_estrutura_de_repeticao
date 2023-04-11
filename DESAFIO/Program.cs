int n1 = 1, n2 = 0;
int soman1n2 = 0;

    while(soman1n2 < 500)
{
    soman1n2 = n1 + n2;
    Console.WriteLine(soman1n2);
    n1 = n2;
    n2 = soman1n2;
}