using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("11995528538", "12345678901234567890", "Nokia 5G", "265GB");

Console.WriteLine("O número do telefone é: {0}", nokia.Numero);
nokia.Ligar();

nokia.InstalarAplicativo("WhatsApp");

Iphone iphoneLixeira = new Iphone("11394558538", "123456789012345232390", "Iphone 15", "265GB");


Console.WriteLine("O número do telefone é: {0}", iphoneLixeira.Numero);
nokia.Ligar();

nokia.InstalarAplicativo("WhatsApp");