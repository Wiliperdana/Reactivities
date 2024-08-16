using System.Text.Json.Serialization;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Persistence;

namespace Application.Profiles
{
    public class UserActivityDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

        [JsonIgnore]
        public string HostUsername { get; set; }
    }
}