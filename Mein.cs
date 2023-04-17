using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alamprogrammid
{
    internal class Mein
    {
        public static void Main(string[] args)
        {
            /*
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Esimene");
            //arrayList.Add("Teine");
            //arrayList.Add("Kolmas");
            //if (arrayList.Contains("Teine"))
            //{
            //    Console.WriteLine("Sõna Teine on olemas");
            //    Console.WriteLine("Teine asub kohal " + arrayList.IndexOf("Teine"));
            //}
            //else
            //{
            //    Console.WriteLine("Otsitav sõna puudub");
            //}
            //Console.WriteLine("Kokku järjendis on "+arrayList.Count+" elemente");
            //arrayList.Insert(3, "Neljas");
            //arrayList.Insert(4, "Viies");
            //arrayList.Sort();
            //foreach (string item in arrayList)
            //{
            //    Console.Write(item + ", ");
            //}
            //arrayList.RemoveAt(0);
            //arrayList.Remove("Viies");
            //arrayList.Clear();

            //List<Inimene> list = new List<Inimene>();
            //Inimene inimene = new Inimene();
            //inimene.Nimi = "Mati";
            //inimene.Vanus = 65;
            //list.Add(inimene);
            //list.Add(new Inimene() { Nimi = "Kati" });

            //foreach (Inimene item in list)
            //{
            //    Console.WriteLine(item.Nimi);
            //}

            //Dictionary<int, string> dic = new Dictionary<int, string>(5);
            //dic.Add(1, "Üks");
            //dic.Add(2, "Kaks");
            //dic[3] = "Kolm";
            //dic.Add(4, "Neli");
            //dic.Add(5, "Viis");
            //foreach (KeyValuePair<int,string> keyValue in dic)
            //{
            //    Console.WriteLine(keyValue.Key+" - "+keyValue.Value);
            //}

            //Dictionary<int, Inimene> õpilased = new Dictionary<int, Inimene>(3);
            //Inimene inimene = new Inimene();
            //inimene.Nimi = "Mati";
            //inimene.Vanus = 65;
            //Inimene inimene2 = new Inimene();
            //inimene2.Nimi = "Kati";
            //inimene2.Vanus = 35;
            //õpilased.Add(1, inimene);
            //õpilased.Add(2, inimene2);
            //õpilased.Add(3, new Inimene() {Nimi = "Marina", Vanus = 100});
            //foreach (Inimene item in õpilased.Values)
            //{
            //    Console.WriteLine(item.Nimi);
            //}

            //foreach (KeyValuePair<int, Inimene> item in õpilased)
            //{
            //    Console.WriteLine(item.Key +": "+item.Value.Nimi);
            //}

            //try
            //{
            //    StreamWriter text = new StreamWriter(@"..\..\..\TextFile.txt",true);
            //    string lause = "Lisan failisse lause\n";
            //    text.WriteLine(lause);
            //    text.Close();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga");
            //    throw;
            //}

            //try
            //{
            //    StreamReader text = new StreamReader(@"..\..\..\TextFile.txt", true);
            //    string laused = text.ReadToEnd();
            //    text.Close();
            //    Console.WriteLine("Failis on jägrmine informatsion: \n");
            //    Console.WriteLine(laused);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga");
            //    throw;
            //}

            //List<string> list_failist = new List<string>();
            //try
            //{
            //    foreach (string rida in File.ReadAllLines(@"..\..\..\TextFile.txt"))
            //    {
            //        list_failist.Add(rida);
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga");
            //    throw;
            //}
            //foreach (var rida in list_failist)
            //{
            //    Console.WriteLine(rida);
            //}


            //ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            //do
            //{
            //    Console.WriteLine("Varjuta Backspace");
            //    nupp=Console.ReadKey();
            //} while (nupp.Key !=ConsoleKey.Backspace);

            //double aritm = Alamprogramm.Keskmine(2);
            //Console.WriteLine(aritm);

            //string kassid = Alamprogramm.Kassi_kalkulaator(25,35,'+');
            //Console.WriteLine(kassid);

            //Alamprogramm.Stars(20);

            //Alamprogramm.NStars(5);
            */

            string filePath = @"C:\Users\user\source\repos\Alamprogrammid-master\Eesti.txt";
            Dictionary<string, string> maakonnad = LoeDictFailist(filePath);

            Console.WriteLine("Sisesta 'help' saadaolevate käskude kuvamiseks.");

                while (true)
                {
                    Console.Write("Sisestage käsk: ");
                    string input = Console.ReadLine().Trim().ToLower();

                    if (input == "help")
                    {
                        Console.WriteLine("Saadaolevad käsud:");
                        Console.WriteLine("  help - kuvab see abiteade");
                        Console.WriteLine("  list - loetlege sõnastikus kõik maakonnad");
                        Console.WriteLine("  otsi - otsib maakonna või pealinna");
                        Console.WriteLine("  <maakond> - näita maakonna pealinna");
                        Console.WriteLine("  <riik> - kuva maakond pealinna jaoks");
                        Console.WriteLine("  test - alustada teadmiste kontrolli maakonna ja pealinna nimede kohta");
                    }
                    else if (input == "list")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Maakonnad:");
                        foreach (KeyValuePair<string, string> maakond in maakonnad)
                        {
                            Console.WriteLine($"  {maakond.Key}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Pealinnad:");
                        foreach (KeyValuePair<string, string> maakond in maakonnad)
                        {
                            Console.WriteLine($"  {maakond.Value}");
                        }
                        Console.WriteLine();
                }
                    else if (maakonnad.ContainsKey(input))
                    {
                        Console.WriteLine($"{maakonnad[input]} on pealinn {input}.");
                    }
                    else if (maakonnad.ContainsValue(input))
                    {
                        string maakond = "";
                        foreach (KeyValuePair<string, string> kvp in maakonnad)
                        {
                            if (kvp.Value == input)
                            {
                                maakond = kvp.Key;
                                break;
                            }
                        }
                        Console.WriteLine($"{input} on pealinn {maakond}.");
                    }
                    else if (input == "test")
                    {
                        Random random = new Random();
                        List<string> countyList = new List<string>(maakonnad.Keys);
                        int tulemus = 0;

                        Console.WriteLine("Sisestage iga maakonna pealinn.");
                        for (int i = 0; i < 10; i++)
                        {
                            string county = countyList[random.Next(countyList.Count)];
                            Console.Write($"{county}: ");
                            string answer = Console.ReadLine().Trim();
                            if (answer == maakonnad[county])
                            {
                                Console.WriteLine("Õige!");
                                tulemus++;
                            }
                            else
                            {
                                Console.WriteLine($"Vale. Õige vastus on {maakonnad[county]}.");
                            }
                        }
                        Console.WriteLine($"Said {tulemus} 10-st ({tulemus * 10}%).");
                    }
                else if (input == "otsi")
                {
                    Console.Write("Kas soovite otsida maakonna või pealinna järgi? (sisestage 'maakond' või 'pealinn'): ");
                    string Otsime = Console.ReadLine().Trim().ToLower();

                    if (Otsime == "maakond")
                    {
                        Console.Write("Sisestage maakonna nimi: ");
                        string maakond = Console.ReadLine().Trim();

                        if (maakonnad.ContainsKey(maakond))
                        {
                            Console.WriteLine($"{maakond} pealinn on {maakonnad[maakond]}.");
                        }
                        else
                        {
                            Console.WriteLine($"Maakonna '{maakond}' pealinna ei leitud.");
                        }
                    }
                    else if (Otsime == "pealinn")
                    {
                        Console.Write("Sisestage pealinna nimi: ");
                        string pealinn = Console.ReadLine().Trim();

                        if (maakonnad.ContainsValue(pealinn))
                        {
                            string maakond = maakonnad.FirstOrDefault(x => x.Value == pealinn).Key;
                            Console.WriteLine($"{pealinn} on maakonna {maakond} pealinn.");
                        }
                        else
                        {
                            Console.WriteLine($"Pealinna '{pealinn}' ei leitud.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Vale sisend '{Otsime}'. Palun sisestage 'maakond' või 'pealinn'.");
                    }
                }
                else
                    {
                        LisaMaakondDict(maakonnad, input);
                    }

                }
                
            }

        static Dictionary<string, string> LoeDictFailist(string filename)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new char[] { ':' }, 2);
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();
                        dictionary[key] = value;
                    }
                    else
                    {
                        Console.WriteLine($"Error: Invalid format on line '{line}'.");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Error: File not found '{filename}'.");
            }

            return dictionary;
        }

        static void LisaMaakondDict(Dictionary<string, string> counties, string input)
        {
            Console.WriteLine($"Ei leidnud '{input}' sõnastikus.");

            Console.Write("Sisestage maakonna nimi: ");
            string county = Console.ReadLine().Trim();

            Console.Write("Sisestage pealinna nimi: ");
            string city = Console.ReadLine().Trim();

            counties[county] = city;

            Console.WriteLine($"Lisatud '{county}' pealinnaga '{city}' sõnaraamatusse.");
        }
    }
}
    
