using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en lista av int
            List<int> lista = new List<int>();

            //Fyll listan med några enstaka värden
            lista.Add(5);
            lista.Add(15);
            lista.Add(25);

            //Lägg till flera tal samtidigt genom att använda en Array med värden
            lista.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });

            //"Iterera" genom listan och skriv ut varje enskilt värde och index.
            //Indexeringen är precis som med Array men istället för .Length finns det en .Count
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Index: {0} Tal: {1}", i, lista[i]);
            }

            //Undersök om ett visst värde finns i listan
            Console.WriteLine("Finns talet 5 i listan? " + lista.Contains(5));
            Console.WriteLine("Finns talet 7 i listan? " + lista.Contains(7));

            //Ta bort första förekomst av ett värde
            lista.Remove(5);

            //Ta bort värde på ett angivet index
            lista.RemoveAt(3);

            //"Iterera" igen, denna gång med en foreach loop
            foreach (int tal in lista)
            {
                Console.WriteLine("Tal: {0}", tal);
            }
            
            //Skapa en lista av double
            List<double> dLista = new List<double>();

            //Lägg till flera tal samtidigt genom att använda en Array med värden
            dLista.AddRange(new double[] { 3.2, 5.1, 13, 7.4, 8.2, 2.8, 14.1 });

            //Skriv ut lite information om innehållet i listan
            Console.WriteLine("Summan av alla element: " + dLista.Sum());
            Console.WriteLine("Medelvärdet: " + dLista.Average().ToString("0.00"));
            Console.WriteLine("Största värdet: " + dLista.Max());
            Console.WriteLine("Minsta värdet: " + dLista.Min());

            //Vilket index hade det minsta värdet...?
            Console.WriteLine("Minsta värdet fanns på index: " + dLista.IndexOf(dLista.Min()));

            //Sortera listan
            dLista.Sort();

            foreach (double d in dLista)
            {
                Console.WriteLine("Värde: " + d);
            }


            Console.ReadKey();
        }
    }
}
