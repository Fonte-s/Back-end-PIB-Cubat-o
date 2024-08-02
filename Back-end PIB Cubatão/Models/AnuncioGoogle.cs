using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Back_end_PIB_Cubatão.Models
{
    [Table("AnuncioGoogle")]
    public class AnuncioGoogle
    {
        [Key]
        public int AnuncioGoogleID { get; set; }
        [Required]
        [StringLength(50)]
        public string? Titulo { get; set; }
        [Required]
        [StringLength(50)]
        public string? CodigoAnuncio { get; set; }
        [Required]
        [StringLength(50)]
        public string? Posicao { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataFim { get; set; }
        [Required]
        public bool Ativo { get; set; }
        [ForeignKey("Pagina")]
        public int PaginaID { get; set; }
        [JsonIgnore]
        public Pagina? Pagina { get; set; }

    }
}
