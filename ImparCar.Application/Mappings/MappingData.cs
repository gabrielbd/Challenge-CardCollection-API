﻿using AutoMapper;
using ImparCar.Application.Requests.Car;
using ImparCar.Application.Response.Car;
using ImparCar.Domain.Entities;

namespace ImparCar.Application.Mappings
{
    public class MappingData : Profile
    {
        public MappingData()
        {
            CreateMap<Car, CreateCarRequest>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Base64, opt => opt.MapFrom(src => src.Photo.Base64));
            CreateMap<CreateCarResponse, Car>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdCar))
                .ForMember(dest => dest.PhotoId, opt => opt.MapFrom(src => src.IdPhoto));

            CreateMap<Photo, CreateCarRequest>()
                .ForMember(dest => dest.Base64, opt => opt.MapFrom(src => src.Base64));
            CreateMap<CreateCarRequest, Photo>()
                .ForMember(dest => dest.Base64, opt => opt.MapFrom(src => src.Base64));

            CreateMap<Car, GetByIdCarRequest>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<GetByIdCarRequest, Car>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));


            CreateMap<UpdateCarRequest, Car>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.PhotoId, opt => opt.MapFrom(src => src.IdPhoto));

            CreateMap<Car, UpdateCarResponse>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.IdCar, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.IdPhoto, opt => opt.MapFrom(src => src.PhotoId))
                .ForMember(dest => dest.Base64, opt => opt.MapFrom(src => src.Photo.Base64));


            CreateMap<Car, CarResponse>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.IdCar, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.IdPhoto, opt => opt.MapFrom(src => src.Photo.Id))
                .ForMember(dest => dest.Base64, opt => opt.MapFrom(src => src.Photo.Base64));

            CreateMap<CarResponse, Car>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdCar))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.Photo.Id, opt => opt.MapFrom(src => src.IdPhoto))
                .ForMember(dest => dest.Photo.Base64, opt => opt.MapFrom(src => src.Base64));
        }
    }
}
