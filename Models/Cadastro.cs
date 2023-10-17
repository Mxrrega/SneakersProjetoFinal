using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SneakersProjetoFinal.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Column("Id_Cadastro")]
        [Display(Name = "IdCadastro")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string NomeCadastro { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email")]
        public string EmailCadastro { get; set; } = string.Empty;

        [Column("CPF")]
        [Display(Name = "CPF")]
        public int CPFCadastro { get; set; }

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; } = string.Empty;

    }
}
