using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Back_end_PIB_Cubatão.Models
{
    [Table("Noticia")]
    public class Noticia
    {
       
          [Key]
            public int NoticiaID { get; set; }
            [Required]
            [StringLength(50)]
            public string? Titulo { get; set; }
            [Required]
            [StringLength(500)]
            public string? Conteudo { get; set; }
            [Required]
            public DateTime? DataPublicao { get; set; }
            [Required]
            [ForeignKey("Igreja")]
             public int IgrejaID { get; set; }
            [JsonIgnore]
             public Igreja Igreja { get; set; }
            [Required]
            [ForeignKey("Membro")]
            public int MembroID { get; set; }
            [JsonIgnore]
             public Membro Membro { get; set; }

    }
    }
