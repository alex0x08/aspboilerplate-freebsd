using System.ComponentModel.DataAnnotations;

namespace TestApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}