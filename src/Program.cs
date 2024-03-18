using System;

class Program
{

public static string TempConvert(double temperature, string unit)
{
    double convertedTemp;
    string newUnit; // Corrected variable name

    if (unit.ToUpper() == "C")
    {
        convertedTemp = (temperature * 9 / 5) + 32;
        newUnit = "F";
    }
    else if (unit.ToUpper() == "F")
    {
        convertedTemp = (temperature - 32) * 5 / 9;
        newUnit = "C";
    }
    else
    {
        throw new ArgumentException("Invalid temperature scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
    }
  
    return $"{convertedTemp} {newUnit}";
}

    public static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Enter temperature value and scale (Celsius 'C' or Fahrenheit 'F'), or type 'quit' to end:");
                string input = Console.ReadLine() ?? "";

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("The program has ended.");
                    break;
                }

                string[] parts = input.Split(" ");
                if (parts.Length != 2)
                {
                    Console.WriteLine("Invalid input. Please enter temperature value and scale.");
               Console.WriteLine("_____________________________________________________________________________________");
                    continue;
                }

                string tempUnit = parts[1].ToUpper();
                if (tempUnit != "C" && tempUnit != "F")
                {
                    Console.WriteLine("Invalid temperature scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
              Console.WriteLine("_____________________________________________________________________________________");
                    continue;
                }
                if (!double.TryParse(parts[0], out double tempValue))
                {
                    Console.WriteLine("Invalid temperature value. Please enter a valid number.");
                 Console.WriteLine("_____________________________________________________________________________________");
                    continue;
                }

                Console.WriteLine($"converted {tempValue} {tempUnit} => "+TempConvert(tempValue,tempUnit));
                Console.WriteLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}
