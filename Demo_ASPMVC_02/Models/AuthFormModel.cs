using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Demo_ASPMVC_02.Models
{
    public class AuthLoginFormModel
    {
        [DisplayName("Votre E-mail")]
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [DisplayName("Votre mot de passe")]
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }

    public class AuthRegisterFormModel
    {
        [DisplayName("E-mail")]
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [DisplayName("Nom d'utilisateur")]
        [Required]
        [MinLength(3), MaxLength(50)]
        [DataType(DataType.Text)]
        [RegularExpression(@"^\w[\w\d_]+$")]
        public required string Pseudo { get; set; }

        [DisplayName("Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Mot de passe")]
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).+$")]
        public required string Password { get; set; }

        [DisplayName("Confirmation du mot de passe")]
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public required string ConfirmPassword { get; set; }

        [DisplayName("J'adore recevoir des spam")]
        [Required]
        public bool AllowNewsletter { get; set; }
    }
}
