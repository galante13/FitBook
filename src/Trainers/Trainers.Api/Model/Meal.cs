using System.Collections.Generic;
using Trainers.Api.Model.Abstract;

namespace Trainers.Api.Model
{
    public class Meal : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int DietId { get; set; }
        public Diet Diet { get; set; }

        public ICollection<MealIngredient> MealIngredients { get; set; }
    }
}