using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Decommentare le funzioni singolarmente per verificarne la funzionalità



            //Parte del conto corrente
            ContoCorrente conto = new ContoCorrente();

            //conto.NewAccount();


            //Parte Dei Nomi
            Nomi listaNomi = new Nomi();

            listaNomi.AggiungiNome("Mario");
            listaNomi.AggiungiNome("Luigi");
            listaNomi.AggiungiNome("Peach");

            //listaNomi.StampaNomi();



            //Parte dei Numeri
            Numbers numbers = new Numbers();
            //numbers.NumbersArray();


            Console.ReadLine();
        }
    }
}
