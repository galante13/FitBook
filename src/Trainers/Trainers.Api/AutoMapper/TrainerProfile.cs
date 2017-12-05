using AutoMapper;
using Trainers.Api.Model;
using Trainers.Api.ViewModels;

namespace Trainers.Api.AutoMapper
{
    public class TrainerProfile : Profile
    {
        public TrainerProfile()
        {
            CreateMap<Trainer, TrainerViewModel>()
                .ForMember(dest => dest.BirthCity, opt => opt.MapFrom(src => src.PersonalInfo.BirthCity))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.PersonalInfo.Date))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.PersonalInfo.Name))
                .ForMember(dest => dest.Nationality, opt => opt.MapFrom(src => src.PersonalInfo.Nationality))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PersonalInfo.PhoneNumber))
            ;

            CreateMap<TrainerViewModel, PersonalInfo>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.BirthDate))
                ;

            CreateMap<TrainerViewModel, Trainer>()
                .ForMember(dest => dest.PersonalInfo, opt => opt.MapFrom(src => src))
                ;
            ;
        }
    }


}