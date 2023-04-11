// Uma certa firma fez uma pesquisa de mercado para saber se as pessoas gostaram ou
//   nao de um novo produto lancado no mercado. Para isto, forneceu o sexo do
//   entrevistado (M-masculino ou F-feminino) e sua resposta (s-sim ou n-nao). Fazer
//   um programa que a partir dos dados fornecidos, no arquivo Pesquisa.dat,
//   calcule e escreva:
//   1. o numero de pessoas que responderam sim;
//   2. o numero de pessoas que responderam nao;
//   3. a porcentagem de pessoas do sexo feminino que responderam sim;
//   4. a porcentagem de pessoas do sexo masculino que responderam nao. 


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
int quantidadeSim = 0, quantidadeNao = 0;

int simFem = 0, simMas = 0;
int naoFem = 0, naoMas = 0;



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


        do     
            {
            Console.Write($"O produto está aprovado: [ S=Sim ou N=Não ]: ");
            resposta =  (Console.ReadLine()) .ToUpper ();
            Console.Clear();
            } 
        
        while (resposta != "S" && resposta != "N");   //  Validar resposta do produto


         switch (sexo)
            {
            case "F" :
                quantidadeFeminino += 1;
                break;

            case "M" :
                quantidadeMasculino += 1;
                break;

            default:
                break;
            }    


            switch (resposta)
            {
            case "S" :
                quantidadeSim += 1;

                if (sexo == "F")       // Pessoas do sexo Feminino
                {                      // que responderam Sim                  
                    simFem += 1;  
                }

                else
                {
                    simMas += 1;
                }

                break;

            case "N" :
                quantidadeNao += 1;
                
                if (sexo == "F")
                {
                    naoFem += 1;
                }

                else                    // Pessoas do sexo Masculino
                {                       // que responderam Não
                    naoMas += 1;
                }

                break;

            default:
                break;
            }    

       
        }
    

float porcetagemMulheres = ((float)quantidadeFeminino / ((float)quantidadeFeminino  + (float) quantidadeMasculino)) * 100 ;
float porcetagemHomens = ((float)quantidadeMasculino/ ((float) quantidadeFeminino + (float)quantidadeMasculino)) * 100 ;


float qtdsimF, qtdnaoF, qtdsimM, qtdnaoM;

if (quantidadeFeminino == 0)
    {
       qtdsimF = 0;
    }

else 
    {
        qtdsimF =  ((float)simFem / (float)quantidadeFeminino) * 100;
    }

if (quantidadeFeminino == 0)
    {
       qtdnaoF = 0;
    }

else 
    {
        qtdnaoF =  ((float)naoFem / (float)quantidadeFeminino) * 100;
    }


 if (quantidadeMasculino == 0)
    {
       qtdsimM = 0;
    }

else 
    {
        qtdsimM =  ((float)simMas / (float)quantidadeMasculino) * 100;
    }


if (quantidadeMasculino == 0)
    {
       qtdnaoM = 0;
    }

else 
    {
        qtdnaoM =  ((float)naoMas / (float)quantidadeMasculino) * 100;
    }



//***** Exibe (ou imprime) os resultados *****//



Console.WriteLine();
Console.WriteLine("Quantidade de Respostas SIM: {0} ", quantidadeSim );
Console.WriteLine("Quantidade de Respostas NÃO: {0} ", quantidadeNao );
Console.WriteLine();
Console.WriteLine(" ..Sexo...   ..%..");
Console.WriteLine($" Feminino:    {porcetagemMulheres}% ");
Console.WriteLine($" Masculino:   {porcetagemHomens}% " );
Console.WriteLine();
Console.WriteLine($" {qtdsimF}% das mulheres responderam sim.");
// Console.WriteLine($" {qtdnaoF}% das mulheres responderam não.");
Console.WriteLine();
// Console.WriteLine($" {qtdsimM}% dos homens responderam sim.");
Console.WriteLine($" {qtdnaoM}% dos homens responderam não.");
Console.WriteLine();

Console.Write("Processo concluido, pressione [ENTER] para sair.");

while (Console.ReadKey().Key != ConsoleKey.Enter) {}

 