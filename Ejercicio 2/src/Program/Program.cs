using System;
using Library;

internal class Program
{
    private static void Main(string[] args)
    {
        string appointmentResult = AppointmentService.CreateAppointment("Jhon", "986782342", "5555-555-555", "","Armand","Neuro", DateTime.Now, "Wall Street");
        Console.WriteLine($"Congratulations! {appointmentResult}");

    }    
}