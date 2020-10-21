using System;
//using System.DateTime;
namespace patient.Models
{
public class Patient
    {
        public int patient_id { get; set; }
        public string patient_name { get; set; }
        //[Column(TypeName="date")
        
         public string DOB { get; set; } 
        public string address { get; set; }
        public string contact{get;set;}
        public string email{ get; set; }
        public string diagnosis_reason{ get; set; }
        public string doctor_name{ get; set; }

        public string appointment_date { get; set; }
        //public DateTime appointment_time { get; set; }
        public Patient(int patient_id, string patient_name,string description)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.description = description;
        }
    }
}
