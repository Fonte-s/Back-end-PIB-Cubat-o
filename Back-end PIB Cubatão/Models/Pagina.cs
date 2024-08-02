using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Back_end_PIB_Cubatão.Models
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
