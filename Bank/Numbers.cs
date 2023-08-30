using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
     public class Numbers
    {
        public void NumbersArray ()
        {
            Console.Write("Inserisci la dimensione dell'array: ");
            int dimensioneArray = Convert.ToInt32(Console.ReadLine());

            int[] mioArray = new int[dimensioneArray];

            for (int i = 0; i < dimensioneArray; i++)
            {
                Console.Write($"Inserisci il valore per l'elemento {i}: ");
                mioArray[i] = int.Parse(Console.ReadLine());
            }


            int somma = 0;
            foreach (int valore in mioArray)
            {
                somma += valore;
            }
            Console.WriteLine($"La somma di tutti i numeri  è: {somma}");

            int media = 0;
            foreach(int valore in mioArray)
            {
                media = somma / valore;
            }
            Console.WriteLine($"La media dei numeri è : {media}");
        }
            
    
     
    }
}
