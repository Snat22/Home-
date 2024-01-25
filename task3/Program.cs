using task3;

Date dateTime = new Date(1,12,2003);
System.Console.WriteLine("---------------------\n");
System.Console.Write($"day : ");
dateTime.Day = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"month: ");
dateTime.Month = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"year: ");
dateTime.Year = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{dateTime.Day}/{dateTime.Month}/{dateTime.Year}");





System.Console.WriteLine($"");