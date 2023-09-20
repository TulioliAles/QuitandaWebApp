﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuitandaWebApp.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preechimento obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres." )]
        public string Nome { get; set; }

        [DataType(DataType.Date, ErrorMessage = "O campo {0} deve conter uma data válida.")]
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "O campo {0} é de preechimento obrigatório.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preechimento obrigatório.")]
        [MaxLength(11, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        [RegularExpression(@"[0-9]{11}$", ErrorMessage = "O campo {0} deve ser preenchido com 11 dígitos numéricos.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preechimento obrigatório.")]
        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage = "O campo {0} deve conter um endereço de e-mail válido.")]
        public string Email { get; set; }
    }
}
