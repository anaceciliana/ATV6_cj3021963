namespace ATV6_cj3021963

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcgeral;

            Console.WriteLine("**MENU DE ATIVIDADES** \n 1-ATIVIDADE DE SALA \n 2-EXERCÍCIO 1 \n 3-EXERCÍCIO 2 \n 4-EXERCÍCIO 3 \n 5-EXERCÍCIO 4 \n 6-EXERCÍCIO 5 \n 7-EXERCÍCIO 6 \n 8-EXERCÍCIO 7");
            opcgeral = int.Parse(Console.ReadLine());

            switch (opcgeral)
            {
                case 1:
                    Console.WriteLine("ATIVIDADE DE SALA");
                    //ATV SALA
                    int a, tp;
                    int soma = 0;
                    a = 0;
                    while (a < 3)
                    {
                        Console.WriteLine("digite um valor: ");
                        tp = int.Parse(Console.ReadLine());
                        if (tp < 0)
                        {
                            break;
                        }
                        soma = soma + tp;
                        a++;
                    }
                    Console.WriteLine("a medida é: {0}", soma / 3);
                    break;

                case 2:
                    Console.WriteLine("ATIVIDADE 1");
                    //ATV 1
                    int n, m;

                    Console.WriteLine("digite um número inteiro: ");
                    m = int.Parse(Console.ReadLine());
                    n = 1;
                    while (n <= m)
                    {
                        Console.WriteLine("{0}", n);
                        n++;
                    }
                    break;

                case 3:
                    Console.WriteLine("ATIVIDADE 2");
                    //ATV 2
                    int a2, n1;

                    Console.WriteLine("Escreva um número inteiro: ");
                    n1 = int.Parse(Console.ReadLine());
                    a2 = 0;
                    while (a2 <= n1)
                    {
                        if (a2 % 2 == 0)
                        {
                            Console.WriteLine(a2);
                        }
                        a2++;
                    }
                    break;

                case 4:
                    Console.WriteLine("ATIVIDADE 3");
                    //ATV 3

                    int div = 1000;

                    Console.WriteLine("Escreva um úmero interiro menor que 1000");
                    int mil = int.Parse(Console.ReadLine());

                    if (mil < 1000)
                    {
                        while (div >= mil)
                        {
                            if ((div % 2) == 0)
                            {
                                Console.WriteLine(div);
                            }
                            div--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("OPÇÃO INVÁLIDA");
                    }
                    break;

                case 5:
                    Console.WriteLine("ATIVIDADE 4");
                    //ATV 4

                    int somaPositivos = 0;

                    while (somaPositivos < 200)
                    {
                        Console.Write("Digite um número inteiro: ");
                        int n2 = int.Parse(Console.ReadLine());

                        if (n2 > 0)
                        {
                            Console.WriteLine("Número positivo: " + n2);
                            somaPositivos += n2;
                        }
                    }
                    Console.WriteLine(" A soma dos números positivos atingiu ou ultrapassou 200.");
                    Console.WriteLine("Programa encerrado.");
                    break;

                case 6:
                    Console.WriteLine("ATIVIDADE 5");
                    //ATV 5

                    int numero;
                    Console.Write("Digite um número inteiro positivo: ");
                    numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de {0}:", numero);

                    int i = 1;
                    while (i <= numero)
                    {
                        if (numero % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                        i++;
                    }
                    break;

                case 7:
                    Console.WriteLine("ATIVIDADE 6");
                    //ATV 6
                    int quantidade = 10;
                    int mn = int.MinValue;
                    int menorNumero = int.MaxValue;

                    int j = 1;
                    while (j <= quantidade)
                    {
                        Console.Write("Digite o número " + j + ": ");
                        int n3 = int.Parse(Console.ReadLine());

                        if (n3 > mn)
                        {
                            mn = n3;
                        }

                        if (n3 < menorNumero)
                        {
                            menorNumero = n3;
                        }
                        j++;
                    }

                    Console.WriteLine("O maior número digitado foi: " + mn);
                    Console.WriteLine("O menor número digitado foi: " + menorNumero);
                    break;

                case 8:
                    Console.WriteLine("ATIVIDADE 7");
                    //ATV 7
                    int somaPares = 0;
                    int somaImpares = 0;

                    while (true)
                    {
                        Console.Write("Digite um número (ou zero para sair): ");
                        int n4 = int.Parse(Console.ReadLine());

                        if (n4 == 0)
                        {
                            break;
                        }

                        if (n4 % 2 == 0)
                        {
                            somaPares += n4;
                        }
                        else
                        {
                            somaImpares += n4;
                        }
                    }

                    Console.WriteLine("Soma dos números pares: " + somaPares);
                    Console.WriteLine("Soma dos números ímpares: " + somaImpares);

                    break;

                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }
    }
}


