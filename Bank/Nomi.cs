using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Nomi
    {
        string[] nomi = new string[15];
        int i = 0;

        public void AggiungiNome(string nome)
        {
            if (i < nomi.Length)
            {
                nomi[i] = nome;
                i++;
            }
            else
            {
                Console.WriteLine("L'array di nomi è pieno. Impossibile aggiungere altri nomi.");
            }
        }

        public void StampaNomi()
        {
            Console.WriteLine("Cerca nome nell'array:");
            string nomeCercato = Console.ReadLine();
            bool trovato = false;
            foreach (string nome in nomi)
            {
                if (!string.IsNullOrEmpty(nome))
                {
                   if (nome == nomeCercato)
                    {
                        trovato = true;
                        break;
                    }
                }

            }
            if (trovato)
            {
                Console.WriteLine($"Il nome '{nomeCercato}' è presente.");
            }
            else {
                Console.WriteLine($"Il nome '{nomeCercato}' non è presente.");
            }

        }
    }


}

