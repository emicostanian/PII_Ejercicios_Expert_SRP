using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        
        public string doctorName { get; set;}
        public string DoctorSpecialty { get; set;}

        public Doctor(string doctorName, string doctorSpecialty)
        {
            this.doctorName = doctorName;
            this.DoctorSpecialty = DoctorSpecialty;   
        }
        
        
    }
}
