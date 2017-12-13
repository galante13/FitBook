using AutoMapper;
using Planner.Api.Model;
using Planner.Api.ViewModels;

namespace Planner.Api.AutoMapper
{
    public class TrainingPlanProfile : Profile
    {
        public TrainingPlanProfile()
        {
            CreateMap<TrainingPlan, TrainingPlanViewModel>();
            CreateMap<TrainingPlanViewModel, TrainingPlan>()
                .ForMember(src => src.CaloriesInDiet, cfg => cfg.Ignore());
        }
    }
}