using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Back_end_PIB_Cubatão.Models
{
    [Table("Eventos")]
    public class Eventos
    {
            [Key]
            public int EventoID { get; set; }
            [Required]
            [StringLength(50)]
            public string? Nome { get; set; }
            [Required]
            [StringLength(50)]
            public string? Descricao { get; set; }
            [Required]
            public DateTime DataHoraInicio { get; set; }
            [Required]
            public DateTime DataHoraFim { get; set; }
            [Required]
            [StringLength(100)]
            public string? Local { get; set; }
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

        public enum Tipo
        {
            Culto,
            Encontro,
            Retiro,
            Outro,
        }

    }
}
