using System;

namespace Trainers.Api.ViewModels
{
    public class TrainerViewModel
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string Code { get; set; }
        public string Bio { get; set; }
        public string City { get; set; }
    }
}