Console.Write (@$"
--------------------------------------------------------------------------------------------------
                     Programa para verificar se a nota esta entre zero e dez 1.0                        
--------------------------------------------------------------------------------------------------
");


//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//


double nota;

Console.Write(@$"Digite uma nota entre zero e dez: ");
nota = double.Parse (Console.ReadLine()) ;

while (nota <=0 || nota >10)     
{
    Console.Clear();
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("                ERRO, digite um valor válido !                    ");
    Console.WriteLine("------------------------------------------------------------------");

    Console.Write("Digite seu usuário:");    
    nota = double.Parse (Console.ReadLine()) ;
}