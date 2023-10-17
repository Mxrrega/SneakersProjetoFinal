using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SneakersProjetoFinal.Models
{

    [Table("CadastroProduto")]
    public class CadastroProduto
    {
        [Column("Id_CadastroProduto")]
        [Display(Name = "IdCadastroProduto")]
        public int Id { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; } = string.Empty;

        [Column("DescricaoProduto")]
        [Display(Name = "Descrição do Produto")]
        public string DescricaoProduto { get; set; } = string.Empty;

        [ForeignKey("Id_Categoria")]
        [Display(Name = "Categoria")]
        public int Id_Categoria { get; set; }

        public Categoria? Categoria { get; set; }

        [Column("ImagemProduto")]
        [Display(Name = "Imagem do Produto")]
        public string ImagemProduto { get; set; } = string.Empty;
    }
}
