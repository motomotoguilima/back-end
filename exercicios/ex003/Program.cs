Console.WriteLine("Digite o numero de um mes:");
string mes = Console.ReadLine();

switch (mes)
{
    case 1:
    Console.WriteLine("janeiro tem 31 dias");
    break;
    case 2:
    Console.WriteLine("fevereiro tem 28 ou 29 dias");
    break;
    case 3:
    Console.WriteLine("marco tem 31 dias");
    break;
    case 4:
    Console.WriteLine("abril tem 30 dias");
    break;
    case 5:
    Console.WriteLine("maio tem 31 dias");
    break;
    case 6:
    Console.WriteLine("junho tem 30 dias");
    break;
    case 7:
    Console.WriteLine("julho tem 31 dias");
    break;
    case 8:
    Console.WriteLine("agosto tem 31 dias");
    break;
    case 9:
    Console.WriteLine("setembro tem 30 dias");
    break;
    case 10:
    Console.WriteLine("outubro tem 31 dias");
    break;
    case 11:
    Console.WriteLine("novembro tem 30 dias");
    break;
    case 12:
    Console.WriteLine("dezembro tem 31 dias");
    break;
    default:
    Console.WriteLine("Dia invalido");
    break;
}