/*
https://www.youtube.com/watch?v=f84n5oFoZBc&list=PLZdCLR02grLrEwKaZv-5QbUzK0zGKOOcr&index=8

*/

/*
mkdir MyApp
cd MyApp
dotnet new console

File → Open Folder
select the MyApp
Select Yes 

"console": "integratedTerminal" in launch.json file
*/

using System;

namespace Cviceni {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Nazdar Svete");
            
            euclid();
            horner();

            int[] a = sort();
            binsearch(a, int.Parse(Console.ReadLine()));
        }

        static void euclid() {
            Console.WriteLine("Zadej dvě kladná celá čísla:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (a != b) {
                if (a > b) {a -= b;}
                else b -= a;
            }
            Console.WriteLine("Nejv. spol. dělitel: {0}", a);
            Console.ReadLine(); 
        }

        static void horner() {
            int v;
            int c;
            c = Console.Read();
            // preskocit ne-cislice:
            while ((c < '0') || (c > '9')) {
                c = Console.Read();
            }         
            // nacitat cislice:
            v = 0;
            while ((c >= '0') && (c <= '9')) {
                v = 10 * v + (c - '0');
                c = Console.Read();
            }
            Console.WriteLine(v);
            Console.ReadLine();  
        }

        static int[] sort() {
            Console.Write("Počet čísel: ");
            int pocet = int.Parse(Console.ReadLine());
            int[] a;
            a = new int[pocet];
            int i = 0;
            while (i < a.Length)
                a[i++] = int.Parse(Console.ReadLine());
            i = 0;
            while (i < a.Length) {
                int k = i;
                int j = i+1;
                while (j < a.Length) {
                    if (a[j] < a[k]) k = j;
                    j++;
                }
                if (k != i) {
                    int x = a[i];
                    a[i] = a[k];
                    a[k] = x;
                }
                i++;
            }
            i = 0;
            while (i < a.Length)
                Console.Write(" {0}", a[i++]);
            Console.WriteLine();

            return a;  
        }

        static void binsearch(int[] a, int number) {
            // Binarnim vyhledavanim najit index number
        }

        static int max(int[] a) {
            return 0;
        }

        static void erastotenes() {

        }
    }
}
