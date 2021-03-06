/* 
* Purpose: Receive temperatures from user and
* give the number of inputs with the average temperature
*
* To compile the program:
* csc DailyTemps.cs
*
* To execute the program:
* DailyTemps.exe (.exe optional)
*
*/
 
using System;
using static System.Console;

namespace DailyTemps
{				
	public class Program
	{
		public static void Main()
		{
			//Define variables
			const int LOW = -20;
			const int HIGH = 130;
			int sum = 0;
			int count = 0;
			double average = 0;
       			string temperatureString;
			int temperature;
		
			Write ("Enter a temperature between -20 and 130 degrees Fahrenheit. When finished enter 000. ");
		
			temperatureString = ReadLine();
			temperature = Convert.ToInt32(temperatureString);
			
			//Run after receiving user input
			while(temperature != 000)
			{
				//If user input is invalid
				while(temperature < LOW || temperature > HIGH)
				{
					Console.Write("Input of {0} is not a valid temperature. Enter a valid temperature.", temperatureString);
					temperatureString = ReadLine();
					temperature = Convert.ToInt32(temperatureString);
				}
			//If user input is valid
			sum += temperature;
			count++;
			Console.Write ("Enter a temperature between -20 and 130 degrees Fahrenheit. When finished enter ##.");
			temperatureString = ReadLine();
			temperature = Convert.ToInt32(temperatureString);
			}
		
			//Run to finish and terminate program
			if(temperature == 000)
			{
				average = sum / count;
				WriteLine("The number of temperatures entered was {0} with an average of {1}.", count, average);
			}
		}
	}
}
