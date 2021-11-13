using System.ComponentModel.DataAnnotations;

namespace Senior.Boilerplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}