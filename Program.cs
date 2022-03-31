Console.WriteLine("Favor digitar o turno que você trabalha:");
Console.WriteLine("Sendo M-matutino");
Console.WriteLine("      V-vespertino");
Console.WriteLine("      N-noturno"); 
Console.WriteLine("Digite a opção:"); 
var turno = Console.ReadLine();
if( turno == "M"){
    Console.WriteLine("Bom Dia");
}else if(turno == "V"){
    Console.WriteLine("Boa Tarde");
}else if(turno =="N"){
    Console.WriteLine("Boa Noite");
}else{
    Console.WriteLine("Valor Inválido");
}
            

