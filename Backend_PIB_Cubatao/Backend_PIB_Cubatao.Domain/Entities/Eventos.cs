using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Backend_PIB_Cubatao.Domain.Entities
{
    [Table("Eventos")]
    public class Eventos
    {
        [Key]
        [Required]
        public int EventosID {get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }
        [Required]
        public DateTime DataHoraInicio { get; set; }
        [Required]
        public DateTime DataHoraFim { get; set; }
        [Required]
        [StringLength(100)]
        public string Local { get; set;}
        [Required]
        [ForeignKey("Igreja")]
        public int IgrejaId { get; set; }
        public Igreja Igreja { get; set; }
        public enum Tipo
        {
            Culto,
            Encontro,
            Retiro,
            Outro
        }
    }
}