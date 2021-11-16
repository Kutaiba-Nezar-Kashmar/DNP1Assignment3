using System.Text.Json.Serialization;

namespace FamilyDataServer.Models
{
    public class Adult : Person
    {
        public Job JobTitle { get; set; }
        [JsonIgnore] public Family Family;
    }
}