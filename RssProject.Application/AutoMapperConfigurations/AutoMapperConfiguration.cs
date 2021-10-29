using AutoMapper;
using RssProject.Application.Dtos;
using System;
using System.Linq;
using System.ServiceModel.Syndication;

namespace RssProject.Application.AutoMapperConfigurations
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<SyndicationFeed, NewsFeedDto>()
                .ForMember(dest => dest.Title, opt =>
                {
                    opt.MapFrom(src => src.Title.Text);
                })
                .ForMember(dest => dest.Desc, opt =>
                {
                    opt.MapFrom(src => src.Description.Text);
                })
                .ForMember(dest => dest.Entries, opt =>
                {
                    opt.MapFrom(src => src.Items.ToList());
                })
                .ForMember(dest => dest.ImgUrl, opt =>
                {
                    opt.MapFrom(src => src.ImageUrl);
                });

            CreateMap<SyndicationItem, EntryDto>()
                .ForMember(dest => dest.Title, opt =>
                {
                    opt.MapFrom(src => src.Title.Text);
                })
                .ForMember(dest => dest.Link, opt =>
                {
                    opt.MapFrom(src => src.Links.Count > 0 ? src.Links[0].Uri : null);
                })
                .ForMember(dest => dest.PubDate, opt =>
                {
                    opt.MapFrom((src, dest) =>
                    {
                        var dt = src.PublishDate.UtcDateTime;
                        var eet = TimeZoneInfo.FindSystemTimeZoneById("E. Europe Standard Time");
                        var dtEet = TimeZoneInfo.ConvertTimeFromUtc(dt, eet);

                        if (eet.IsDaylightSavingTime(dtEet))
                        {
                            dtEet = dtEet.AddHours(-1);
                        }
                        return dtEet;
                    });
                })
                .ForMember(dest => dest.Authors, opt =>
                {
                    opt.MapFrom(src => src.Authors.ToList());
                });

            CreateMap<SyndicationPerson, string>()
                .ConvertUsing(p => p.Name ?? p.Email);
        }
    }
}
