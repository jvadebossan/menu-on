using System.ComponentModel.DataAnnotations;

namespace MenuOn.Dtos
{
    public class ProdutoInserir
    {
        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do produto é obrigatória")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "A descrição deve ter entre 5 e 300 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A URL da imagem é obrigatória")]
        [Url(ErrorMessage = "A URL da imagem é inválida")]
        [StringLength(250, ErrorMessage = "A URL da imagem deve ter no máximo 250 caracteres")]
        public string ImagemUrl { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório")]
        [Range(0.01, 999999.99, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Preco { get; set; }


        [Required(ErrorMessage = "O id da categoria é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "O valor deve ser positivo")]
        public int CategoriaId { get; set; }

        public bool? Disponivel { get; set; } = true;
    }

    public class ProdutoAtualizar
    {
        // Atributos opcionais
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres")]
        public string? Nome { get; set; }

        [StringLength(300, MinimumLength = 5, ErrorMessage = "A descrição deve ter entre 5 e 300 caracteres")]
        public string? Descricao { get; set; }

        [Url(ErrorMessage = "A URL da imagem é inválida")]
        [StringLength(250, ErrorMessage = "A URL da imagem deve ter no máximo 250 caracteres")]
        public string? ImagemUrl { get; set; }

        [Range(0.01, 999999.99, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal? Preco { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O valor deve ser positivo")]
        public int? CategoriaId { get; set; }
        public bool? Disponivel { get; set; } = true;
    }

}
