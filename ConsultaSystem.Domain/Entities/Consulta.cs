﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsultaSystem.Domain.Entities
{
    public class Consulta : Entity
    {
        [Required]
        [Display(Name = "Horário")]
        public DateTime Horario { get; set; }

        [Required]
        public string Protocolo { get; set; }

        [Required]
        public int IDPaciente { get; set; }

        [ForeignKey("IDPaciente")]
        public virtual Paciente Paciente { get; set; }

        [Required]
        public int IDTipoDeExame { get; set; }

        [ForeignKey("IDTipoDeExame")]
        [Display (Name = "Tipo de Exame")]
        public virtual TipoDeExame TipoDeExame { get; set; }

        [Required]
        public int IDExame { get; set; }

        [ForeignKey("IDExame")]
        public virtual Exame Exame { get; set; }

    }
}