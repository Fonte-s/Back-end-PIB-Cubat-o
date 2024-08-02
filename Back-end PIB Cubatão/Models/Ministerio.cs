using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Back_end_PIB_Cubatão.Models
{
    [Table("Ministerio")]
    public class Ministerio
    {
        [Key]
        public int MinisterioID { get; set; }
        [Required]
        [StringLength(50)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(250)]
        public string? Descricao { get; set; }
        [Required]
        [ForeignKey("Igreja")]
        public int IgrejaID { get; set; }
        [JsonIgnore]
        public Igreja? Igreja { get; set; }
        [Required]
        [ForeignKey("Membro")]
        public int MembroID { get; set; }
        [JsonIgnore]
        public Membro? Membro { get; set; }

    }
}
