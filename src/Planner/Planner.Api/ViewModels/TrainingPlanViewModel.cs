namespace Planner.Api.ViewModels
{
    public class TrainingPlanViewModel
    {
        public int Id { get; set; }

        public int TrainerId { get; set; }
        public int DietId { get; set; }

        public int CaloriesInDiet { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

    }
}