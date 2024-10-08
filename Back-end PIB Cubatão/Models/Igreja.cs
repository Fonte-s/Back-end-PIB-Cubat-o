﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Back_end_PIB_Cubatão.Models
{
    [Table("Igreja")]
    public class Igreja
    {
       

            [Key]
            public int IgrejaID { get; set; }
            [Required]
            [StringLength(50)]
            public string? Nome { get; set; }
            [Required]
            [StringLength(100)]
            public string? Endereco { get; set; }
            [Required]
            [StringLength(100)]
            [EmailAddress]
            public string Email { get; set; }
            [JsonIgnore]
            public DateTime DataDeFundacao { get; set; }

        
    }
}
