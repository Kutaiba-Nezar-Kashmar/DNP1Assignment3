using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FamilyDataServer.Models
{
    public class Job
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        [JsonIgnore]
        public IList<Adult> Adults { get; set; } = new List<Adult>();

    }
}