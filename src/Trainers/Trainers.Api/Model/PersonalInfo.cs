using System;

namespace Trainers.Api.Model
{
    //Complex Type
    public class PersonalInfo
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string BirthCity { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }
    }
}