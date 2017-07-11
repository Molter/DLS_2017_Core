using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace DLS_2017.Models
{
    public class Speaker 
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é Obrigatório")]
        [Display(Name = "Nome Completo")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Email é Obrigatório")]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Entre um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Título é Obrigatório")]
        [Display(Name = "Título")]
        [StringLength(80)]
        public string PresetationSubject { get; set; }

        [Required(ErrorMessage = "Campo Detalhes é Obrigatório")]
        [Display(Name = "Detalhes da Palestra")]
        [StringLength(2000)]
        public string PresetationDetails { get; set; }

        [Required(ErrorMessage = "Campo Currículo é Obrigatório")]
        [Display(Name = "Currículo")]
        [StringLength(2000)]
        public string SpeakerDetails { get; set; }
        public string Photo { get; set; }
        public string Linkedin { get; set; }

        public string FaceBook { get; set; }
        public string Twitter { get; set; }
        public string GPlus { get; set; }

        [Required(ErrorMessage = "Campo Telefone é Obrigatório")]
        [Display(Name = "Telefone")]
        [StringLength(80)]
        public string Phone{ get; set; }

        [BindNever]
        public bool IsSelected { get; set; }
    }
}
