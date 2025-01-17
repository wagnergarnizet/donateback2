﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Backend.Domain.Models
{
    public class Campanha
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de Descrição é obrigatório")]
        public string Descricao { get; set; }

        public string Logotipo { get; set; }

        public bool Ativo { get; set; }

        public DateTime Dt_inicio { get; set; }

        public DateTime Dt_fim { get; set; }

        public virtual Instituicao Instituicao{ get; set; }
        public int InstituicaoId { get; set; }
    
        public virtual List<Estoque> Estoques { get; set; }

        public virtual List<Produto_Campanha> Produto_Campanhas { get; set; }

    }
}
