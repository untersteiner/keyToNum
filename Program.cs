using System;
using System.Collections.Generic;

namespace keyToNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dicciKeyToNum = new Dictionary<char, int>();
            dicciKeyToNum = initData();
            int flag = 0;
            
            Console.WriteLine("\n¡Bienvenido a la app KeyToNum!\n");

            while (flag != 3)
            {
                switch (flag)
                {
                    case 0:
                        break;
                    case 1:
                        string palabra;
                        Console.WriteLine("Ingrese palabra o frase a transformar: \n");
                        palabra = Console.ReadLine().Trim().ToLower();
                        traduc(palabra);
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        instru();
                        break;
                    default:
                        Console.WriteLine("\nIngrese una opcion valida.\n");
                        break;
                }
                Console.WriteLine("Ingresa una opcion para continuar: \n");
                Console.WriteLine("1 - Iniciar aplicacion");
                Console.WriteLine("2 - Intrucciones");
                Console.WriteLine("3 - Salir \n");

                if (flag == 3)
                {
                    Console.WriteLine("\nGracias por ustilizar nuestra aplicacion.");
                }

                flag = Convert.ToInt32(Console.ReadLine());
            }

            void traduc(string palabra){
                char[] palabraArray = palabra.ToCharArray();
                
                List<int> fraseANum = new List<int>();

                foreach (var letra in palabraArray)
                {
                    if (dicciKeyToNum.ContainsKey(letra))
                    {
                        fraseANum.Add(dicciKeyToNum[letra]);
                    }
                }
                
                Console.WriteLine("\nEl resultado de su frase es: \n");

                foreach (var num in fraseANum)
                {
                    if (num != 0)
                    {
                        Console.Write(num);
                    }else
                    {
                        Console.Write(" ");
                    }
                    
                }
            }


            Dictionary<char, int> initData()
            {
                Dictionary<char, int> dicciKeyToNumFun = new Dictionary<char, int>();
                dicciKeyToNumFun.Add(' ', 0);
                dicciKeyToNumFun.Add('a', 2);
                dicciKeyToNumFun.Add('b', 22);
                dicciKeyToNumFun.Add('c', 222);
                dicciKeyToNumFun.Add('d', 3);
                dicciKeyToNumFun.Add('e', 33);
                dicciKeyToNumFun.Add('f', 333);
                dicciKeyToNumFun.Add('g', 4);
                dicciKeyToNumFun.Add('h', 44);
                dicciKeyToNumFun.Add('i', 444);
                dicciKeyToNumFun.Add('j', 5);
                dicciKeyToNumFun.Add('k', 55);
                dicciKeyToNumFun.Add('l', 555);
                dicciKeyToNumFun.Add('m', 6);
                dicciKeyToNumFun.Add('n', 66);
                dicciKeyToNumFun.Add('o', 666);
                dicciKeyToNumFun.Add('p', 7);
                dicciKeyToNumFun.Add('q', 77);
                dicciKeyToNumFun.Add('r', 777);
                dicciKeyToNumFun.Add('s', 7777);
                dicciKeyToNumFun.Add('t', 8);
                dicciKeyToNumFun.Add('u', 88);
                dicciKeyToNumFun.Add('v', 888);
                dicciKeyToNumFun.Add('w', 9);
                dicciKeyToNumFun.Add('x', 99);
                dicciKeyToNumFun.Add('y', 999);
                dicciKeyToNumFun.Add('z', 9999);
                return dicciKeyToNumFun;
            }
            
            void instru(){
                Console.WriteLine("Ingrese una palabra o frase y la aplicacion la convertira en su equivalente de pulsaciones de un teclado de celular.\nPuede escribir con espacios por delante o por atras, con mayusculas, con numeros, con caracteres especiales, etc.\nLa aplicacion siempre le devolvera la frase traducida.\n");
            }
        }
    }
}
