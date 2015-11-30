using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BSU.ASP._15._01.Day14.Bunjak.Models
{
    public class RegistrationStudent
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "e-Mail")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Университет")]
        public string University { get; set; }

        [Display(Name = "Курс")]
        [Range(1, 5, ErrorMessage = "Недопустимый курс")]
        public int Course { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int TrainingId { get; set; }
    }
}