for (var numero = 1; numero <= 10; numero++)
{   
    Console.WriteLine(@$"A tabuada do número {numero} é: ");
    Console.WriteLine();
    
        for (var multiplicador = 1; multiplicador <= 10; multiplicador++)
        {
        Console.WriteLine($"{numero} X {multiplicador} = {numero * multiplicador}");
        }
        Console.WriteLine();
}