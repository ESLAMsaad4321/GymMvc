using System.ComponentModel.DataAnnotations;

namespace GymMvc.Models
{
    public class WorkOut
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Image { get; set; } = string.Empty;
        public int sets { get; set; }
        public int reps { get; set; }
        public string Description { get; set; } = string.Empty;

    }
}
