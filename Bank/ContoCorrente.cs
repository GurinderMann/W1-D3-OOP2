using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ContoCorrente
    {
        public int saldo = 0;
      
        public void NewAccount()
        {
            Console.WriteLine("Vuoi aprire un nuovo Conto corrente? (y/n)");
            string risposta = Console.ReadLine();

            if (risposta == "y")
            {
                Console.WriteLine("Effettua un versamento di 1000$ (y/n)");
                string versamento = Console.ReadLine();

                if (versamento == "y")
                {
                    saldo = 1000;
                    Console.WriteLine("Versamento effettuato. Saldo attuale: " + saldo + "$");
                }
                else
                {
                    Console.WriteLine("Impossibile aprire il conto senza un versamento");
                    return;
                }

                string operazioni;

                do
                {
                    Console.WriteLine("Vuoi Effettuare altre operazioni? (y/n)");
                    operazioni = Console.ReadLine();

                    if (operazioni == "y")
                    {
                        Console.WriteLine("Seleziona un operazione:");
                        Console.WriteLine("Versamento : 1");
                        Console.WriteLine("Prelievo : 2");
                        Console.WriteLine("Saldo totale : 3");
                        string response = Console.ReadLine();

                        if (response == "1")
                        {
                            Console.Write("Inserisci l'importo da versare: ");
                            int importoVersamento = Convert.ToInt32(Console.ReadLine());
                            saldo += importoVersamento;
                            Console.WriteLine("Versamento effettuato il tuo saldo totale è :" + saldo + "$");
                        }
                        else if (response == "2")
                        {
                            Console.WriteLine("Inserisci Importo da prelevare:");
                            int ImportoPrelievo = Convert.ToInt32(Console.ReadLine());
                            saldo -= ImportoPrelievo;
                            Console.WriteLine("Prelievo effettuato con successo il tuo saldo totale è :" + saldo + "$");
                        }
                        else if (response == "3")
                        {
                            Console.WriteLine("Il tuo saldo totale è : " + saldo + "$");
                        }
                      
                    }
                } while (operazioni == "y");
            }
            else
            {
                Console.WriteLine("Grazie e arrivederci");
            }
        }
    }
}
    



