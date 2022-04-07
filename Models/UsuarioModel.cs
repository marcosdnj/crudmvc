using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }


        [Column(TypeName="nvarchar(100)")]
        [Required(ErrorMessage="Um nome é necessário")]
        public string Nome { get; set; }


        [Column(TypeName="nvarchar(30)")]
        [Required(ErrorMessage = "O login é necessário")]
        public string? Login { get; set; }


        [Column(TypeName = "nvarchar(60)")]
        public string? Email { get; set; }


        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Uma senha é necessária")]
        [DataType(DataType.Password)]
        public string  Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        //public DateTime? DataAtualizacao { get; set; }
    }
}
