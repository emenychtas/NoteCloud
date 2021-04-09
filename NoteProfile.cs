using AutoMapper;
using NoteCloud.Entities;
using NoteCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteCloud
{
    public class NoteProfile : Profile
    {
        public NoteProfile()
        {
            CreateMap<Note, NoteDto>()
                .ReverseMap();
        }
    }
}
