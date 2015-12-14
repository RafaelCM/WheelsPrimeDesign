using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WheelsPrime.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        [DisplayName("Fornecedor Selecionado")]
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        [DisplayName("Lmebrar-me?")]
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        [DisplayName("Fornecedor")]
        public string Provider { get; set; }

        [Required]
        [DisplayName("Código")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [DisplayName("Lembrar este browser?")]
        public bool RememberBrowser { get; set; }

        [DisplayName("Lmebrar-me?")]
        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Palavra-Chave")]
        public string Password { get; set; }

        [DisplayName("Lembrar-me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} tem de conter pelo menos {2} carateres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [DisplayName("Palavra-Chave")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Confirmar Palavra-Chave")]
        [Compare("Password", ErrorMessage = "A palavra-chave e a sua confirmação não correspondem.")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Primeiro Nome")]
        public string FirstName { get; set; }

        [DisplayName("Último Nome")]
        public string LastName { get; set; }

        public string NIF { get; set; }

        [DisplayName("Telefone")]
        public string Telephone { get; set; }

        [DisplayName("Telemóvel")]
        public string MobilePhone { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} tem de conter pelo menos {2} carateres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [DisplayName("Palavra-Chave")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Confirmar Palavra-Chave")]
        [Compare("Password", ErrorMessage = "A palavra-chave e a sua confirmação não correspondem.")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Código")]
        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
