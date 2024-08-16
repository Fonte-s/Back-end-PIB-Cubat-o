using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Backend_PIB_Cubatao.Models
{
    [Table("Pagina")]
    public class Pagina
    { 
            [Key]
            public int PaginaID { get; set; }
            [Required]
            [StringLength(50)]
            public string? Nome { get; set; }
            [Required]
            [StringLength(259)]
            public string? LinkVideo { get; set; }

        
    }
}
