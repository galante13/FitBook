using Trainers.Api.Model.Abstract;

namespace Trainers.Api.Model
{
    public class Trainer : Entity
    {
        public Trainer()
        {
            PersonalInfo = new PersonalInfo();
        }

        public PersonalInfo PersonalInfo { get; set; }
        public string Code { get; set; }
        public string Bio { get; set; }
        public string City { get; set; }
    }

}