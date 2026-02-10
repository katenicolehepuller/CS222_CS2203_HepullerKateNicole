using System;

Console.Write("Enter amount in USD: ");
double amountUsd = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter exchange rate from USD to EUR: ");
double rateUsdToEur = Convert.ToDouble(Console.ReadLine());

double amountEur = amountUsd * rateUsdToEur;

Console.WriteLine($"Amount in EUR: {amountEur:F2}");
