using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pro;

            Console.WriteLine("digite um numero: ");
            pro = int.Parse(Console.ReadLine());


            switch (pro)
            {

                case 1:


                    int num1, nump;


                    Console.WriteLine("Digite um numero inteiro: ");
                    num1 = int.Parse(Console.ReadLine());

                    if (num1 >= 0)
                    {
                        Console.WriteLine(num1);
                    }
                    else
                    {
                        nump = num1 * (-1);
                        Console.WriteLine(nump);
                    }



                    break;

                case 2:


                    int num2;

                    Console.WriteLine("Digite um numero: ");
                    num2 = int.Parse(Console.ReadLine());


                    if (num2 % 3 != 0 && num2 % 4 != 0 && num2 % 5 != 0 && num2 % 7 != 0)
                    {
                        Console.WriteLine("O numero é divisivel por 3, 5 , 4 e 7 ");
                    }

                    if (num2 % 3 == 0)
                    {

                        Console.WriteLine("o numero é divisivel por 3 ");


                        if (num2 % 4 == 0)
                        {

                            Console.WriteLine("o numero é divisivel por 4");



                            if (num2 % 5 == 0)
                            {

                                Console.WriteLine("o numero é divisivel por 5 ");



                                if (num2 % 7 == 0)
                                {

                                    Console.WriteLine("o numero é divisivel por 7 ");
                                }



                            }
                        }
                    }



                    break;

                case 3:

                    int a, b, c;

                    Console.WriteLine("qual o valor do primeiro numero ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("qual o valor do segundo numero ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("qual o valor do terceiro numero ");
                    c = int.Parse(Console.ReadLine());

                    if (a > b && b > c)
                        Console.WriteLine(a);

                    else if (a > b && b < c)
                        Console.WriteLine(a);
                    else if (b > a && a > c)
                        Console.WriteLine(b);
                    else if (b > a && a < c)
                        Console.WriteLine(b);
                    else if (c > a && a > b)
                        Console.WriteLine(c);
                    else if (c > a && a < b)
                        Console.WriteLine(c);





                    break;

                case 4:
                    int dia;

                    Console.WriteLine("Digite um número correspondente a um dia da semana (1-7):");
                    dia = int.Parse(Console.ReadLine());


                    if (dia != 1 && dia != 2 && dia != 3 && dia != 4 && dia != 5 && dia != 6 && dia != 7)
                    {
                        Console.WriteLine("o dia è invalido");

                        break;
                    }


                    switch (dia)
                    {
                        case 1:

                            Console.WriteLine("Jogo bola");

                            break;

                        case 2:
                            Console.WriteLine("portugues");

                            break;

                        case 3:

                            Console.WriteLine("matematica");

                            break;

                        case 4:
                            Console.WriteLine("biologia");

                            break;
                        case 5:
                            Console.WriteLine("banco de dados");

                            break;
                        case 6:
                            Console.WriteLine("filosofia");
                            break;
                        case 7:
                            Console.WriteLine("durmo");
                            break;











                    }





                    break;


                case 5:

                    int numa, numaior, numenor;

                    Console.WriteLine("digete um numero: ");
                    numa = int.Parse(Console.ReadLine());
                    numenor = numa;
                    numaior = numa;


                    for (; ; )
                    {

                        Console.WriteLine("digite um numero qualquer e no final digite 0 para parar :");
                        numa = int.Parse((Console.ReadLine()));

                        if (numa == 0)

                            break;
                        if (numa > numaior)
                        {
                            numaior = numa;
                        }
                        else if (numa < numenor)
                        {

                            numenor = numa;
                        }

                        Console.WriteLine("o maior numero è : " + numaior + " e o menor é : " + numenor);

                    }




                    break;

                case 6:

                    int num3, numtotal = 0;

                    Console.WriteLine("qual o numero: ");
                    num3 = int.Parse(Console.ReadLine());
                    for (int i = 1; ; i++)

                        if (num3 % i == 0 && i != num3)
                            numtotal = numtotal + i;

                        else if (numtotal == num3)
                        {
                            Console.WriteLine("o numero é perfeito ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("o numero nao é perfeito ");
                            break;
                        }


                    break;

                case 7:

                    int not, med = 0, quantnot = 0;



                    for (; ; quantnot++)
                    {

                        Console.WriteLine("qual a sua nota?");
                        not = int.Parse(Console.ReadLine());

                        if (not == 0)
                            break;

                        if (not % 2 == 0)
                        {

                            med = med + not;
                        }



                    }

                    med = med / quantnot;
                    if (med == 0)
                    {
                        Console.WriteLine("nao consegui calcular essa média");
                    }

                    Console.WriteLine("a media é:" + med);


                    break;

            }


        }
    }
}