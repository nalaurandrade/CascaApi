using System.ComponentModel.DataAnnotations;

namespace CascaApi.Models
{
    public class Jogador
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracetes")]
        public string Nome { get; set; }

        [StringLength(11, ErrorMessage = "CPF deve ter, no máximo, 11 caracteres")]
        [Required(ErrorMessage = "CPF é obrigatório")]
        public string Cpf { get; set; }
        [StringLength(500, ErrorMessage = "Descrição deve ter no máximo 500 caracteres")]
        [Required(ErrorMessage = "Descrição é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Deve conter os seguintes valores: GL, ZA, LD, LE, VO, MD ou AT Posição do jogador é obrigatório")]
        public string Posicao { get; set; }

    }
}
