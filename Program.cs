using celular;

Celular pocket = new Celular();

Console.WriteLine($"Qual a cor do celular:");
pocket.Color = Console.ReadLine();

Console.WriteLine($"Qual é o modelo do celular");
pocket.Modelo = Console.ReadLine();

Console.WriteLine($"");
pocket.Tamanho = Console.ReadLine();

Console.WriteLine($"Deseja ligar o celuar ? s|n ?");
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
    Console.WriteLine($"Deseja fazer uma ligação? s|n ?");
    
    
}




