using celular;

Celular pocket = new Celular();

Console.Write($"Qual a cor do celular ?");
pocket.Color = Console.ReadLine();

Console.Write($"Qual é o modelo do celular ?");
pocket.Modelo = Console.ReadLine();

Console.Write($"Qual é o tamanho do celular ?");
pocket.Tamanho = Console.ReadLine();

Console.Write($"Deseja ligar o celuar ? s|n ?");
string resposta = Console.ReadLine();

switch (resposta)
{
    case "s": pocket.Ligar();
        break;
    case "n": pocket.Desligar();
        break;
    default:
        break;
}

while(pocket.Ligado == true)
{
    Console.Write($"Deseja fazer uma ligação? s|n ?");
    resposta = Console.ReadLine();
    
    if (resposta == "s")
    {
        pocket.FazerLigacao();
    }
    else if (resposta == "n")
    {
        Console.WriteLine($"okay okay");
        
        
    }

    Console.Write($"Deseja enviar mensagem ?");
    resposta = Console.ReadLine();
    
    if (resposta == "s")
    {
        pocket.EnviarMensagem();
    }
    else
    {
        Console.Write($"Okay Okay");
        
    }

    Console.Write($"Deseja desligar o celular ?");
    resposta = Console.ReadLine();
    
    if (resposta == "s")
    {
        pocket.Desligar();
    }
    else
    {
        pocket.Ligado = true;
    }
    
    
    
}




