using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MoneyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double ballanceInRuble= 0;
            double ballanceInDollar = 0;
            double ballanceInEuro = 0;
            double rubleToDollarRatio = 0.0154;
            double rubleToEuroRatio = 0.147;
            double euroToDollarRatio = 1.04;
            double dollarToEuroRatio = 0.95;
            double dollarToRubleRatio = 64.6;
            double euroToRubleRatio = 67.7;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Конвертер валют:");
                Console.WriteLine("");
                Console.WriteLine("Добро пожаловать в конвертер валют выберите интересующий вас пункт введя его номер:");
                Console.WriteLine("1 - Пополнить баланс");
                Console.WriteLine("2 - Конвертировать валюту");
                Console.WriteLine("3 - Показать баланс");
                Console.WriteLine("4 - Выйти");

                string key = Console.ReadLine();

                switch (key)
                {

                    case "1":

                        Console.Clear();
                        Console.WriteLine("Пополнение баланса:");
                        Console.WriteLine("");
                        Console.WriteLine("1 - Доллар; 2 - Евро; 3 - Рубли");

                        Console.Write("В какой валюте хотите пополнить деньги:");
                        string currencyForReplenishment = Console.ReadLine();

                        Console.Write("На какую сумму хотите пополнить:");
                        string amountOfMoneyForReplenishment = Console.ReadLine();

                        switch (currencyForReplenishment)
                        {

                            case "1":

                                ballanceInDollar += Convert.ToDouble(amountOfMoneyForReplenishment);

                                Console.WriteLine();
                                Console.WriteLine("Спасибо, что воспользовались услугами нашего конвертера");
                                Console.WriteLine($"Ваш баланс состоваляет {ballanceInDollar} долларов");

                                break;

                            case "2":

                                ballanceInEuro += Convert.ToDouble(amountOfMoneyForReplenishment);

                                Console.WriteLine();
                                Console.WriteLine("Спасибо, что воспользовались услугами нашего конвертера");
                                Console.WriteLine($"Ваш баланс состоваляет {ballanceInEuro} евро");

                                break;

                            case "3":

                                ballanceInRuble += Convert.ToDouble(amountOfMoneyForReplenishment);

                                Console.WriteLine();
                                Console.WriteLine("Спасибо, что воспользовались услугами нашего конвертера");
                                Console.WriteLine($"Ваш баланс состоваляет {ballanceInRuble} рублей");

                                break;

                        }

                        Console.ReadKey();

                        break;

                    case "2":

                        Console.Clear();
                        Console.WriteLine("Конвертация валют:");
                        Console.WriteLine();

                        Console.WriteLine("1 - Доллар; 2 - Евро; 3 - Рубли");
                        Console.Write("Из какой валюты хотите конвертировать:");
                        string currencyFromConvert = Console.ReadLine();

                        Console.WriteLine("1 - Доллар; 2 - Евро; 3 - Рубли");
                        Console.Write("В какую валюту хотите конвертировать:");
                        string currencyToConvert = Console.ReadLine();

                        Console.Write("Сколько валюты хотите перевести?:");
                        string amountOfMoneyForConvert = Console.ReadLine();

                        switch (currencyFromConvert)
                        {

                            case "1":

                                if (currencyToConvert == "1")
                                {
                                    Console.WriteLine("Ваш баланс составил: " + ballanceInDollar);
                                }
                                else if (currencyToConvert == "2")
                                {
                                    ballanceInDollar -= Convert.ToDouble(amountOfMoneyForConvert);
                                    ballanceInEuro += Convert.ToDouble(amountOfMoneyForConvert) * dollarToEuroRatio;

                                    Console.WriteLine("Ваш баланс составил: " + ballanceInDollar + "долларов");
                                    Console.WriteLine("Ваш баланс составил: " + ballanceInEuro + "Евро");
                                }
                                else
                                {
                                    ballanceInDollar -= Convert.ToDouble(amountOfMoneyForConvert);
                                    ballanceInRuble += Convert.ToDouble(amountOfMoneyForConvert) * dollarToRubleRatio;

                                    Console.WriteLine("Ваш баланс составил: " + ballanceInDollar + "долларов");
                                    Console.WriteLine("Ваш баланс составил: " + ballanceInRuble + "рублей");
                                }

                                break;

                            case "2":

                                if (currencyToConvert == "2")
                                {
                                    Console.WriteLine("Ваш баланс составил: " + ballanceInEuro);
                                }
                                else if (currencyToConvert == "1")
                                {
                                    ballanceInEuro -= Convert.ToDouble(amountOfMoneyForConvert);
                                    ballanceInDollar += Convert.ToDouble(amountOfMoneyForConvert) * euroToDollarRatio;

                                    Console.WriteLine("Ваш баланс составил: " + ballanceInEuro + "Евро");
                                    Console.WriteLine("Ваш баланс составил: " + ballanceInDollar + "долларов");
                                }
                                else
                                {
                                    ballanceInEuro -= Convert.ToDouble(amountOfMoneyForConvert);
                                    ballanceInRuble += Convert.ToDouble(amountOfMoneyForConvert) * euroToRubleRatio;

                                    Console.WriteLine("Ваш баланс составил: " + ballanceInEuro + "Евро");
                                    Console.WriteLine("Ваш баланс составил: " + ballanceInRuble + "рублей");
                                }

                                break;

                            case "3":

                                if (currencyToConvert == "3")
                                {
                                    Console.WriteLine("Ваш баланс составил: " + ballanceInRuble);
                                }
                                else if (currencyToConvert == "1")
                                {
                                    ballanceInRuble -= Convert.ToDouble(amountOfMoneyForConvert);
                                    ballanceInDollar += Convert.ToDouble(amountOfMoneyForConvert) * rubleToDollarRatio;

                                    Console.WriteLine("Ваш баланс составил: " + ballanceInRuble + "рублей");
                                    Console.WriteLine("Ваш баланс составил: " + ballanceInDollar + "долларов");
                                }
                                else
                                {
                                    ballanceInRuble -= Convert.ToDouble(amountOfMoneyForConvert);
                                    ballanceInEuro += Convert.ToDouble(amountOfMoneyForConvert) * rubleToEuroRatio;

                                    Console.WriteLine("Ваш баланс составил: " + ballanceInRuble + "рублей");
                                    Console.WriteLine("Ваш баланс составил: " + ballanceInEuro + "евро");
                                }

                                break;
                               
                        }

                        Console.ReadKey();

                        break;

                    case "3":

                        Console.WriteLine("Ваш баланс:");
                        Console.WriteLine("Доллары: " + ballanceInDollar);
                        Console.WriteLine("Евро: " + ballanceInEuro);
                        Console.WriteLine("Рубли: " + ballanceInRuble);

                        Console.ReadKey();

                        break;

                    case "4":

                        Console.Clear();
                        Console.WriteLine("Спасибо, что заглянули. До новых встреч!");

                        Thread.Sleep(2000);
                        Environment.Exit(0);

                        break;
                }
            }
        }
    }
}
