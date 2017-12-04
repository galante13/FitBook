using System;
using System.Collections.Generic;
using Trainers.Api.Model.Abstract;

namespace Trainers.Api.Model
{
    public class Diet : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        public ICollection<Meal> Meals { get; set; }
    }
}