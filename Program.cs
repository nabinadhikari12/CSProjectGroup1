// Final Project: C# Object-Oriented Programming
// Project: CSharp - Final Project - Group1
//Group Members:
// Nabin Adhikari(200582800)
// Ajay Kumar(200581288)
//Nandini Verma(200582490)
//Instructor name: Anmar Jarjees
//Semester: 4
// Program: Computer System Technician - Networking(CSTN)


using System; // Include the System namespace for Console and other basic features

// Main program class
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Ask user to enter first name and save it
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        // Ask user to enter last name and save it
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        // Ask user to enter weight in kilograms
        Console.Write("Enter Weight (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Ask user to enter height in centimeters
        Console.Write("Enter Height (cm): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Ask user to enter systolic blood pressure (upper value)
        Console.Write("Enter Systolic BP (upper): ");
        int systolic = Convert.ToInt32(Console.ReadLine());

        // Ask user to enter diastolic blood pressure (lower value)
        Console.Write("Enter Diastolic BP (lower): ");
        int diastolic = Convert.ToInt32(Console.ReadLine());

        // Create a new Patient object using the data entered
        Patient patient = new Patient(firstName, lastName, weight, height);

        // Call method to print all patient info
        patient.PrintPatientInfo(systolic, diastolic);

        // Pause before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
