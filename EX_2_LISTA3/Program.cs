Console.Write (@$"
--------------------------------------------------------------------------------------------------
                     Programa para verificar usuário e senha 1.0                        
--------------------------------------------------------------------------------------------------
");


//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//


string usuario, senha;


Console.Write(@$"Digite seu usuário: ");
usuario = Console.ReadLine() ;

Console.Write(@$"Digite sua senha: ");
senha = Console.ReadLine() ;


while (usuario == senha)     
{
    Console.Clear();
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("           ERRO, a senha deve ser diferente do usuário!"       );
    Console.WriteLine("------------------------------------------------------------------");

    Console.Write("Digite seu usuário:");    
    usuario = Console.ReadLine();    

    Console.Write("Digite sua senha:");    
    senha = Console.ReadLine();    
}