using System;
using Ioco.DTO;
using AutoMapper;
using Ioco.EntityFrameWork;
using System.Linq.Expressions;

namespace Ioco.Core.Mapping
{
    public static class DtoMapping
    {
        public static bool isInitialize { get; set; }
        public static void Map()
        {
            if (!isInitialize)
            {
                AutoMapper.Mapper.Initialize(
                    config =>
                    {
                        config.CreateMap<Pet, PetDTO>().ReverseMap();
                        config.CreateMap<Owner, OwnerDTO>().ReverseMap().DisableCtorValidation();
                    });
                isInitialize = true;
            }
        }

        public static IMappingExpression<TSource, TDestination> Ignore<TSource, TDestination>(
            this IMappingExpression<TSource, TDestination> map,
            Expression<Func<TDestination, object>> selector)
        {
            map.ForMember(selector, config => config.Ignore());
            return map;
        }
    }
}
