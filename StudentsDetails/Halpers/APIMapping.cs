using AutoMapper;
using StudentsDetails.Dto;
using StudentsDetails.Models;

namespace StudentsDetails.Halpers
{
    public class APIMapping:Profile
    {
        public APIMapping()
        {
            CreateMap<StudentsDetailDto, Student>();
        }
    }
}
