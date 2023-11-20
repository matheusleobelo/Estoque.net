using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaPrimeiraAPI.Models
{
    public class Saida
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }

        [Column(name: "Produto")]
        public Produto Produto { get; set; }

        [Required]
        [Column(name: "DataSaida")]
        public DateTime DataSaida { get; set; }

        [Column(name: "PrecoUnitario")]
        public double PrecoUnitario { get; set; }

        [Column(name: "Quantidade")]
        public int Quantidade { get; set; }
    }
}
