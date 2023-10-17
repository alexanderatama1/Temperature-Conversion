//Declare necessary variables.
double temperature, conversion; // 'temperature' will hold the original temperature, 'conversion' will hold the converted value.
string unit1, unit2; // 'unit1' and 'unit2' will hold the units for temperature conversion.

// Present the user with a welcome message and menu.
Console.WriteLine("Welcome to Temperature Conversion!");
Console.WriteLine("==================================");
Console.WriteLine("Available units are (C)elsius, (F)ahrenheit, and (K)elvin.\n");

// Prompt the user to enter the temperature value. 
// It is assumed here that the user enters a valid double value.
Console.Write("Enter Temperature: ");
temperature = double.Parse(Console.ReadLine()); // Parse the input as double to handle decimal values.

// Ask the user for the current unit of the temperature entered.
Console.Write("Enter Unit: ");
unit1 = Console.ReadLine().ToUpper(); // Convert the input to uppercase for consistency in comparison.

// Request the unit the user would like to convert the temperature to.
Console.Write("Enter Conversion Unit: ");
unit2 = Console.ReadLine().ToUpper(); // Convert the input to uppercase to match the units' format.

// A newline for better readability of the upcoming output.
Console.WriteLine();

// Check the unit that the temperature is currently in.
if (unit1 == "C") // If the current unit is Celsius.
{
    // Determine the target unit and calculate accordingly.
    if (unit2 == "F") // Convert Celsius to Fahrenheit.
    {
        conversion = Math.Round(temperature * 9 / 5 + 32, 2); // Formula for conversion.
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}."); // Inform the user of the result.
    }
    else if (unit2 == "K") // Convert Celsius to Kelvin.
    {
        conversion = Math.Round(temperature + 273.15, 2); // Formula for conversion.
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}."); // Inform the user of the result.
    }
    // If the source and target units are the same, inform the user.
    else if (unit2 == "C")
    {
        Console.WriteLine($"We cannot convert {unit1} to {unit2}!"); // No conversion needed.
    }
    else
    {
        // Handle the case where the target unit is unknown or unsupported.
        Console.WriteLine($"The unit {unit2} is not valid!");
    }
}
else if (unit1 == "F") // If the current unit is Fahrenheit.
{
    // Similar structure as the above, specialized for Fahrenheit as the source unit.
    if (unit2 == "F")
    {
        Console.WriteLine($"We cannot convert {unit1} to {unit2}!.");
    }
    else if (unit2 == "K") // Convert Fahrenheit to Kelvin.
    {
        conversion = Math.Round(((temperature - 32) * 5 / 9) + 273.15, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else if (unit2 == "C") // Convert Fahrenheit to Celsius.
    {
        conversion = Math.Round((temperature - 32) * 5 / 9, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else
    {
        Console.WriteLine($"The unit {unit2} is not valid!");
    }
}
else if (unit1 == "K") // If the current unit is Kelvin.
{
    // Now dealing with conversions from Kelvin.
    if (unit2 == "F") // Convert Kelvin to Fahrenheit.
    {
        conversion = Math.Round((temperature - 273.15) * 9 / 5 + 32, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else if (unit2 == "K")
    {
        Console.WriteLine($"We cannot convert {unit1} to {unit2}!"); // No conversion needed.
    }
    else if (unit2 == "C") // Convert Kelvin to Celsius.
    {
        conversion = Math.Round(temperature - 273.15, 2);
        Console.WriteLine($"A temperature of {temperature}{unit1} is {conversion}{unit2}.");
    }
    else
    {
        Console.WriteLine($"The unit {unit2} is not valid!"); // If the target unit is not recognized.
    }
}
else // If the source unit is not recognized.
{
    Console.WriteLine($"The unit {unit1} is not valid!");
}