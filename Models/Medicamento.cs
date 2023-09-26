using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using MySql.EntityFrameworkCore.DataAnnotations;


namespace APIExemplo.Models
{
    public class Medicamento
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Descricao { get; set; }
        [Required(ErrorMessage ="O Lote deve ser informado.")]
        public string Lote { get; set; }
        public int MesVencimento { get; set; }
        [Required(ErrorMessage ="O ano de vencimento não pode ser o ano atual.")]
        public int AnoVencimento { get; set; }
        public string Marca { get; set; }
        public string Fabricante { get; set; }
    }
}
