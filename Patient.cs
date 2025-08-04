// Final Project: C# Object-Oriented Programming
// Project: CSharp - Final Project - Group1
//Group Members:
// Nabin Adhikari(200582800)
// Ajay Kumar(200581288)
//Nandini Verma(200582490)
//Instructor name: Anmar Jarjees
//Semester: 4
// Program: Computer System Technician - Networking(CSTN)


using System; // Required for basic C# functionality

// Define a class to represent a patient
public class Patient
{
    // Private fields to store patient data
    private string _firstName;
    private string _lastName;
    private double _weight;
    private double _height;

    // Public property to get/set first name
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    // Public property to get/set last name
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    // Public property to get/set weight in kilograms
    public double Weight
    {
        get { return _weight; }
        set { _weight = value; }
    }

    // Public property to get/set height in centimeters
    public double Height
    {
        get { return _height; }
        set { _height = value; }
    }

    // Constructor to initialize patient details
    public Patient(string firstName, string lastName, double weight, double height)
    {
        _firstName = firstName;
        _lastName = lastName;
        _weight = weight;
        _height = height;
    }

    // Public method to check and return blood pressure category
    public string CheckBloodPressure(int systolic, int diastolic)
    {
        // Check ranges using conditions and return result message
        if (systolic < 120 && diastolic < 80)
            return "Normal";
        else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            return "Elevated";
        else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
            return "High Blood Pressure (Hypertension) Stage 1";
        else if ((systolic >= 140 && systolic <= 180) || (diastolic >= 90 && diastolic <= 120))
            return "High Blood Pressure (Hypertension) Stage 2";
        else if (systolic > 180 || diastolic > 120)
            return "Hypertensive Crisis (Consult your doctor immediately)";
        else
            return "Invalid blood pressure values.";
    }

    // Private method to calculate Body Mass Index (BMI)
    private double CalculateBMI()
    {
        // Convert height from cm to meters
        double heightInMeters = _height / 100;

        // Apply BMI formula = weight / (height * height)
        return _weight / (heightInMeters * heightInMeters);
    }

    // Public method to print all patient information
    public void PrintPatientInfo(int systolic, int diastolic)
    {
        Console.WriteLine("----- Patient Information -----");

        // Display full name, weight, and height
        Console.WriteLine($"Name: {_firstName} {_lastName}");
        Console.WriteLine($"Weight: {_weight} kg");
        Console.WriteLine($"Height: {_height} cm");

        // Call blood pressure method and print result
        string bpResult = CheckBloodPressure(systolic, diastolic);
        Console.WriteLine($"Blood Pressure: {bpResult}");

        // Call BMI method and print numeric result
        double bmi = CalculateBMI();
        Console.WriteLine($"BMI: {bmi:F2}");

        // Determine and print BMI category
        if (bmi >= 25)
            Console.WriteLine("BMI Status: Overweight");
        else if (bmi >= 18.5 && bmi <= 24.9)
            Console.WriteLine("BMI Status: Normal (Healthy Range)");
        else
            Console.WriteLine("BMI Status: Underweight");
    }
}
