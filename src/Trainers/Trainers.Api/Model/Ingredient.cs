using System;
using System.Collections.Generic;
using Trainers.Api.Model.Abstract;

namespace Trainers.Api.Model
{
    public class Ingredient : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //In 100 grams
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }

        //TODO Use Kcal Calculator
        public double Kcal => throw new NotImplementedException();

        public ICollection<MealIngredient> MealIngredients { get; set; }
    }
}