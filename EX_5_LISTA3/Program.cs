// Programa que recebe, de 10 pessoas:
// sexo, idade e peso

// Calcula e imprime:
// Total de mulheres
// Total de homens 
// A idade média das mulheres
// A idade média dos homens
// O peso médio das mulheres
// O peso médio dos homens


Console.Write (@$"
--------------------------------------------------------------------------------------------------
                     Programa para determinar o nível de aceitação do produto 1.0                        
--------------------------------------------------------------------------------------------------
");
 Console.WriteLine("");
 

//************************************** ENTRADA DE DADOS ********************************************//

Console.WriteLine($"Determinando o nível de aceitação do produto");
Console.WriteLine($"Início do processo...");
Console.WriteLine();


Console.Write("Pressione [ENTER] para prosseguir.");
while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();

         //******** DECLARAÇÃO DAS VARIÁVEIS **********//
int quantidadeEntrevistados = 2;  // Total de pessoas entrevistadas

int quantidadeFeminino = 0, quantidadeMasculino = 0;
int idadeMulher, idadeHomem, idadeTotalMulheres= 0, idadeTotalHomens = 0;
float pesoMulher, pesoHomem, pesoTotalMulheres = 0, pesoTotalHomens = 0;





string sexo, resposta;

        for (int i = 1; i <= quantidadeEntrevistados; i++) 
        {

        Console.WriteLine("Entrevistado {0} de {1}", (i),quantidadeEntrevistados );
        Console.WriteLine();
        
        do     

            {
            Console.Write($"Digite seu sexo: [ F=Feminino ou M=Masculino ]: ");
            sexo =  (Console.ReadLine()) .ToUpper ();
            Console.WriteLine("");
            
            } 
        
        while (sexo != "F" && sexo != "M");   //  Validar resposta do sexo da pessoa



         switch (sexo)
            {
            case "F" :
                quantidadeFeminino += 1;

                Console.Write($"Digite sua idade: ");
                idadeMulher = int.Parse(Console.ReadLine());
                idadeTotalMulheres += idadeMulher;

                Console.WriteLine();

                Console.Write($"Digite seu peso: ");
                pesoMulher = int.Parse(Console.ReadLine());
                pesoTotalMulheres += pesoMulher;
                
                Console.Clear();
        
                break;

            case "M" :
                quantidadeMasculino += 1;
                
                Console.Write($"Digite sua idade: ");
                idadeHomem = int.Parse(Console.ReadLine());
                idadeTotalHomens += idadeHomem;

                Console.WriteLine();

                Console.Write($"Digite seu peso: ");
                pesoHomem = int.Parse(Console.ReadLine());
                pesoTotalHomens += pesoHomem;

                Console.Clear();

                break;

            default:
                break;
            }    

        }
    




//***** Exibe (ou imprime) os resultados *****//



Console.WriteLine(@"                    ======================================================================
                                         QUANTIDADE DE ENTREVISTADOS
                    ======================================================================");
Console.WriteLine();
Console.WriteLine(@$"                                 A quantidade total de mulheres entrevistadas é: {quantidadeFeminino} ");
Console.WriteLine();
Console.WriteLine(@$"                                 A quantidade total de homens entrevistados é: {quantidadeMasculino} ");
Console.WriteLine();

Console.WriteLine(@"                    ======================================================================
                                              IDADE MÉDIA
                    ======================================================================");
Console.WriteLine();

if (quantidadeFeminino == 0)
    {
       Console.WriteLine(@$"                    ERRO! Não foi possível realizar a média da idades das mulheres, pois não 
                          tiveram mulheres cadastradas na pesquisa. ");
       Console.WriteLine();
    }

else
{
    Console.Write(@$"                                 A média da idade das mulheres é: {idadeTotalMulheres / quantidadeFeminino} ");
    Console.WriteLine($"anos");
    Console.WriteLine();
}

if (quantidadeMasculino == 0)
    {
       Console.WriteLine(@$"                    ERRO! Não foi possível realizar a média da idades dos homens, pois não 
                          tiveram homens cadastrados na pesquisa. ");
       Console.WriteLine();
       
    }

else
{
    Console.Write(@$"                                 A média das idades dos homens é: {idadeTotalHomens / quantidadeMasculino} ");
    Console.WriteLine($"anos");
    Console.WriteLine();
}


Console.WriteLine(@"                    ======================================================================
                                               PESO MÉDIO
                    ======================================================================");
Console.WriteLine();

if (quantidadeFeminino == 0)
    {
       Console.WriteLine(@$"                    ERRO! Não foi possível realizar a média de peso das mulheres, pois não 
                          tiveram homens cadastrados na pesquisa. ");
       Console.WriteLine();
    }

else
{
    Console.Write(@$"                                 A média de peso das mulheres é: {(float)pesoTotalMulheres / (float)quantidadeFeminino} ");
    Console.WriteLine($"quilogramas");
    Console.WriteLine();
}

if (quantidadeMasculino == 0)
    {
      Console.WriteLine(@$"                    ERRO! Não foi possível realizar a média de peso dos homens, pois não 
                          tiveram homens cadastrados na pesquisa.");
       Console.WriteLine();
       
    }

else
{
    Console.Write(@$"                                 A média de peso dos homens é: {(float)pesoTotalHomens / (float)quantidadeMasculino} ");
    Console.WriteLine($"quilogramas");
    Console.WriteLine();
    
}



Console.WriteLine();
Console.Write("Processo concluido, pressione [ENTER] para sair.");

while (Console.ReadKey().Key != ConsoleKey.Enter) {}

 