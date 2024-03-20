int num = 4;
float n, n1, n2, operacao, op;

Console.WriteLine("bem vindo a calculadora!");
Console.WriteLine("dois numeros: ");
n1 = float.Parse(Console.ReadLine());
n2 = float.Parse(Console.ReadLine());
Console.WriteLine("esclha sua operação, sendo elas:");
Console.WriteLine("1-muitiplicação" + "\n" + "2-divisão" + "\n" + "3-adição" + "\n" + "4-subtração");
operacao = int.Parse(Console.ReadLine());

switch (operacao)
{
    case 1:
       n =  n1 * n2;
        Console.WriteLine("o resultado foi de :{0}", n);
        break;

        case 2:
        n = n1 / n2;
        Console.WriteLine("o resultado foi de :{0}", n);
        break;

        case 3:
        n = n1 + n2;
        Console.WriteLine("o resultado foi de :{0}", n);
        break;

        case 4:
        n = n1 - n2;
        Console.WriteLine("o resultado foi de :{0}", n);
        break;

        default:
        Console.WriteLine("opção invalida,tente de novo");
        break;


}



