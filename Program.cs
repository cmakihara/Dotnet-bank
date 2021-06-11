using System;

namespace DIO.Series
{
	public class pizzaria
	{
		public static void Main()
		{
            int timeInSeconds = int.Parse(Console.ReadLine());

       //continue a solucao
            var hours = 0;      
            var minutes =  0 ;
            var seconds =   0 ;

			Console.WriteLine("1: " + timeInSeconds);
        
			while (timeInSeconds >= 60)
			{
				minutes += 1;
                timeInSeconds -= 60;
						
				 if (minutes == 60)
				{
					hours += 1;
					minutes = 0;
				}
				if(timeInSeconds < 60 && timeInSeconds > 0)
				{
					seconds = timeInSeconds;
				}				
			}            

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}