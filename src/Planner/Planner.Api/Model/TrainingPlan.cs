using Planner.Api.Model.Abstract;

namespace Planner.Api.Model
{
    public class TrainingPlan : Entity
    {
        public int TrainerId { get; set; }
        public int DietId { get; set; }

        //field created to stimulate need of EventBus.
        public int CaloriesInDiet { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        //TODO Exercises...
    }
}