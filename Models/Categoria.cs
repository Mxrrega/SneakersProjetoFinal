using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SneakersProjetoFinal.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Column("CategoriaId")]
        [Display(Name = "CategoriaId")]
        public int CategoriaId { get; set; }

        [Column("NomeCategoria")]
        [Display(Name = "Nome da Categoria")]
        public string NomeCategoria { get; set; } = string.Empty;
    }
}
