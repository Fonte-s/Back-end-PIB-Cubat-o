using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Backend_PIB_Cubatao.Domain.Entities
{
	[Table("Sermao")]
	public class Sermao
	{
		[Key]
		public int SermaoID { get; set; }
		[Required(ErrorMessage = "Título é obrigatório")]
		[StringLength(50)]
		public string? Titulo { get; set; }
		[Required]
		[ForeignKey("Membro")]
		public int MembroID { get; set; }
		[JsonIgnore]
		public Membro? Membro { get; set; }
		public DateTime Data { get; set; }
		[StringLength(500)]
		public string? TextoBiblico { get; set; }
		[StringLength(500)]
		public string? Descricao { get; set; }
		[StringLength(250)]
		public string? LinkVideo { get; set; }
	}
}
