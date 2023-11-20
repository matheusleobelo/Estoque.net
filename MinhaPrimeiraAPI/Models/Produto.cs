using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaPrimeiraAPI.Models
{
    public class Produto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "Nome")]
        public string Nome { get; set; }

        [Column(name: "Descricao")]
        public string Descricao { get; set; }

        [Required]
        [Column(name: "DataEntrada")]
        public DateTime DataEntrada { get; set; }
    }
}
