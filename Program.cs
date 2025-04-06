Console.WriteLine("Temperature Converter");
Console.WriteLine("\n\nChoose an option:\n 1. Celsius to Fahrenheit\n 2. Celsius to Kelvin\n 3. Fahrenheit to Celsius\n 4. Fahrenheit to Kelvin\n 5. Kelvin to Fahrenheit\n 6. Kelvin to Celsius");
Console.Write("\n\nChoose the conversion type by entering the corresponding number(1-7): ");
int temp;
bool isValidTemp = int.TryParse(Console.ReadLine(), out temp);


switch (temp)
{
    case 1:
        Console.Write("Enter the temperature you wish to convert(Celsius): ");
        double t = Convert.ToDouble(Console.ReadLine());

        double c = t * 9 / 5 + 32;
        Console.WriteLine("Fahrenheit: " + c);
        break;

    case 2:
        Console.Write("Enter the temperature you wish to converte(Celsius): ");
        double k = Convert.ToDouble(Console.ReadLine());

        double ce = k + 273.15;
        Console.WriteLine("Kelvin: " + ce);
        break;

    case 3:
        Console.Write("Enter the temperature you wish to convert(Fahrenheit): ");
        double fa = Convert.ToDouble(Console.ReadLine());

        double f = (fa - 32) * 5 / 9;
        Console.WriteLine("Celsius: " + f);
        break;

    case 4:
        Console.Write("Enter the temperature you wish to convert(Fahrenheit): ");
        double fah = Convert.ToDouble(Console.ReadLine());

        double fh = (fah - 32) * 5 / 9 + 237.15;
        Console.WriteLine("Kelvin: " + fh);
        break;

    case 5:
        Console.Write("Enter the temperature you wish to convert(Kelvin): ");
        double ke = Convert.ToDouble(Console.ReadLine());

        double kel = ke - 273.15;
        Console.WriteLine("Celsius: " + kel);
        break;

    case 6:
        Console.Write("Enter the temperature you wish to convert(Kelvin): ");
        double kelvin = Convert.ToDouble(Console.ReadLine());

        double kelvin1 = (kelvin - 273.15) * 9 / 5 + 32;
        Console.WriteLine("Fahrenheit: " + kelvin1);
        break;

    default:
        Console.WriteLine("Invalid Temperature.");
        break;
} 
