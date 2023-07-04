using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAula.Models
{
    [Table("Professor")]
    public class Professor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        
        [Column(name: "Nome")]
        public string Nome { get; set; }
        
        [Column(name: "Cpf")]
        public string Cpf { get; set; }

        [Column(name: "Titulacao")]
        public string Titulacao { get; set; }
    }
}
