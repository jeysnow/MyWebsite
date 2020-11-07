using AutoMapper;
using Logic.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Models;

namespace Website.Mapping
{
    public class Maps: Profile
    {
        public Maps()
        {
            CreateMap<Experience, ExperienceVM>().ReverseMap();
            CreateMap<Tag, TagVM>().ReverseMap();
        }
    }
}
