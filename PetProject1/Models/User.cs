using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PetProject1.Models
{
    public class User
    {
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан возраст")]
        [Range(18, 120, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Не указана почта")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректная почта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Не указан адрес")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Не указан почтовый индекс")]
        public int PostIndex { get; set; }
    }
}
