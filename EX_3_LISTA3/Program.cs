Console.Write (@$"
--------------------------------------------------------------------------------------------------
                     Programa para informar a tabuada de um numero inteiro 1.0                        
--------------------------------------------------------------------------------------------------
");
 Console.WriteLine("");
 

//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//
int tabuada;

Console.Write(@$"Digite a tabuada que deseja visualizar: ");
tabuada = int.Parse (Console.ReadLine()) ;
Console.Clear();

Console.WriteLine($"A tabuada do {tabuada} sera apresentada abaixo ");
Console.WriteLine("");


for (int n = 0; n <= 10; n++)
    
Console.WriteLine("{0} x {1} = {2}  ", tabuada, n, (tabuada * n));
 

