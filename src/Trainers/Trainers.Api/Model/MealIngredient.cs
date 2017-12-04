using System;
using System.Collections.Generic;
using Trainers.Api.Model.Abstract;

namespace Trainers.Api.Model
{
    public class MealIngredient : Entity
    {
        public double QuantityInGrams { get; set; }
        //TODO Use WeightUnits Converter
        public double QuantityInOunces => throw new NotImplementedException();

        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}