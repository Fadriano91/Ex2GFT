 string opcaoUsuario = ObterOpcaoUsuario();

switch (opcaoUsuario.ToUpper())
               {
                    case "M":
                        System.Console.WriteLine("Bom Dia");
                        break;
                    case "V":
                        System.Console.WriteLine("Boa Tarde");                   
                        break;
                    case "N":
                        System.Console.WriteLine("Boa Noite");
                        break;
                    default:
                    throw new ArgumentOutOfRangeException();                
               }
    opcaoUsuario = ObterOpcaoUsuario();

string ObterOpcaoUsuario()
{
    Console.WriteLine();
            Console.WriteLine("Favor digitar o turno que você trabalha:");
            Console.WriteLine("Sendo M-matutino");
            Console.WriteLine("      V-vespertino");
            Console.WriteLine("      N-noturno");            
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
}

