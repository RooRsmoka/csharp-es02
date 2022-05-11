using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 0;
            //for (int i = 0; i < 256; i++)
            //{
            //    if (n == 16)
            //    {
            //        Console.WriteLine();
            //        n = 0;
            //    }
            //    n++;
            //    Console.Write("{0} ", (char)i);
            //}
            //for (char pluto = 'a'; pluto < 'z'; pluto++)
            //    Console.WriteLine((long)pluto);

            string[] comandi = new string[] {"Somma", "Moltiplicazione", "Divisione", "Sottrazione", "Quadrato", "Media"};
            Console.WriteLine("Digita un numero da 0 a 5 per effetuare diverse operazioni.");
            Console.WriteLine("0->Somma, 1->Moltiplicazione, 2->Divisione, 3->Sottrazione, 4->Quadrato, 5->Media");
            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "0":
                    {
                        Console.WriteLine("Operazione selezionata: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.WriteLine("Inserisci due numeri, sulla stessa riga e separati da uno spazio, per effettuare l'addizione");
                        string sNums = Console.ReadLine();
                        if (sNums == null)
                        {
                            Console.WriteLine("Non sono stati inseriti numeri.");
                            Environment.Exit(1);
                        }
                        string[] sVect = sNums.Split(' ');

                        int numOne = Convert.ToInt32(sVect[0]);
                        int numTwo = Convert.ToInt32(sVect[1]);

                        Console.WriteLine("La somma dei numeri inseriti è: {0}", numOne + numTwo);
                    }
                    break;
                case "1":
                    {
                        Console.WriteLine("Operazione selezionata: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.WriteLine("Inserisci due numeri, sulla stessa riga e separati da uno spazio, per effettuare la moltiplicazione");
                        string sNums = Console.ReadLine();
                        if (sNums == null)
                        {
                            Console.WriteLine("Non sono stati inseriti numeri.");
                            Environment.Exit(1);
                        }
                        string[] sVect = sNums.Split(' ');

                        int numOne = Convert.ToInt32(sVect[0]);
                        int numTwo = Convert.ToInt32(sVect[1]);

                        Console.WriteLine("Il prodotto dei numeri inseriti è: {0}", numOne * numTwo);
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("Operazione selezionata: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.WriteLine("Inserisci due numeri, sulla stessa riga e separati da uno spazio, per effettuare la divisione");
                        string sNums = Console.ReadLine();
                        if (sNums == null)
                        {
                            Console.WriteLine("Non sono stati inseriti numeri.");
                            Environment.Exit(1);
                        }
                        string[] sVect = sNums.Split(' ');

                        int numOne = Convert.ToInt32(sVect[0]);
                        int numTwo = Convert.ToInt32(sVect[1]);

                        Console.WriteLine("Il risultato della divisione è: {0}", numOne / numTwo);
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("Operazione selezionata: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.WriteLine("Inserisci due numeri, sulla stessa riga e separati da uno spazio, per effettuare la sottrazione");
                        string sNums = Console.ReadLine();
                        if (sNums == null)
                        {
                            Console.WriteLine("Non sono stati inseriti numeri.");
                            Environment.Exit(1);
                        }
                        string[] sVect = sNums.Split(' ');

                        int numOne = Convert.ToInt32(sVect[0]);
                        int numTwo = Convert.ToInt32(sVect[1]);

                        Console.WriteLine("Il risultato della sottrazione dei numeri inseriti è: {0}", numOne - numTwo);
                    }
                    break;
                case "4":
                    {
                        Console.WriteLine("Operazione selezionata: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.WriteLine("Inserisci un numero per effettuare il calcolo del quadrato");
                        int numOne = int.Parse(Console.ReadLine());
                        double result = Math.Pow(numOne, 2);
                        Console.WriteLine("Il quadrato del numero inserito è: {0}", result);
                    }
                    break;
                case "5":
                    {
                        Console.WriteLine("Operazione selezionata: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.WriteLine("Inserisci un elenco di numeri, sulla stessa riga e separati da uno spazio, per effettuare il calcolo della media");
                        string sNums = Console.ReadLine();
                        if (sNums == null)
                        {
                            Console.WriteLine("Non sono stati inseriti numeri.");
                            Environment.Exit(1);   
                        }
                        string[] sVect = sNums.Split(' ');
                        double media = 0.0;
                        int quantità = 0;
                        foreach (string sNum in sVect)
                        {
                            double num;
                            if (double.TryParse(sNum, out num))
                            {
                                media += num;
                                quantità++;
                            }
                        }
                        media /= quantità;
                        Console.WriteLine("La media dei numeri inseriti è: {0}", media);
                    }
                    break;
                default:
                    Console.WriteLine("L'operazione selezionata non è valida: {0}", cmd);
                    break;
            }
        }
    }
}