using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        

        public static string CreateAppointment(string name, string id, string phoneNumber, string age, string doctorName, string doctorSpecialty, DateTime date, string appoinmentPlace)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
 

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(age))
            {
                stringBuilder.Append("Unable to schedule appointment, 'patient age' is required\n");
                isValid = false;
            }
            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctorSpecialty))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor specialty' is required\n");
                isValid = false;
            }


            if (isValid)
            {
                Patient patientData = new Patient(name,id, phoneNumber,age);
                Doctor doctorData = new Doctor(doctorName, doctorSpecialty);
                stringBuilder.Append($"Appoinment scheduled the {date}, at {appoinmentPlace} for {name} id number: {id} with Dr.{doctorName}, seecialty {doctorSpecialty}");
            }

            return stringBuilder.ToString();
        }

    }
}
