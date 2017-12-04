using Model.Abstract;

namespace Model
{
    public class Trainer : Entity
    {
        public PersonalInfo PersonalInfo { get; set; }
        public string Code { get; set; }
        public string Bio { get; set; }
        public string City { get; set; }
    }

}