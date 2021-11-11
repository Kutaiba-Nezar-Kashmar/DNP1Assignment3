using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FamilyDataServer.Models
{
    public class Interest
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            return $"{Type} {Description}";
        }
    }
}