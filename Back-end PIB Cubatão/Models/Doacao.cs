using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Back_end_PIB_Cubatão.Models
{
    [Table("Doacao")]
    public class Doacao
    {
                [Key]
                public int DoacaoID { get; set; }
                [Required]
                public DateTime? Data { get; set; }
                [Required]
                [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero")]    
                public decimal Valor { get; set; }
                [Required]  
                [ForeignKey("Igreja")]
                [JsonIgnore]
                public int IgrejaID { get; set; }

        public enum MetodoPagamento
        {
            CartãoCredito,
            CartãoDebito,
            Pix
        }

    }
    
}
