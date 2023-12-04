using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FilesPractics.Entities
{
    public class ProfileTeacher
    {
        // jsonga chiqarmedi
        [JsonIgnore]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = default!;

        // bu json ga ko'rsatilmedi ko'rinmedi
        [JsonIgnore]
        public string? ImageUrl { get; set; }

        //bu bazaga qo'shilmaydi
        [NotMapped]
        public IFormFile? Image { get; set; }
    }
}
