using System.ComponentModel.DataAnnotations;

namespace lso.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}