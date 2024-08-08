using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Back_end_PIB_Cubatão.Models
{

    [Table("Membro")]
    public class Membro
    {


        [Key]
        public int MembroID { get; set; }
        [Required]
        [StringLength(50)]
        public string? NomeMembro { get; set; }
        [Required]
        [StringLength(50)]
        public string? SobrenomeMembro { get; set; }
        [Required]
        public DateTime DataDeNascimento { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }
        [Required]
        [Phone]
        [StringLength(15)]
        public string? Telefone { get; set; }
        [Required]
        public DateTime DataDeCadastro { get; set; }
        [Required]
        [ForeignKey("Ministerio")]
        public int MinisterioID { get; set; }
        [JsonIgnore]
        public Ministerio? Ministerio { get; set; }
        [Required]
        public Status Status { get; set; }   

}
    public enum Status
    {
        Ativo,
        Inativo
    }
}
