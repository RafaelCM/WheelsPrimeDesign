using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.ComponentModel;

namespace WheelsPrime.Models
{
    public class IndexViewModel
    {
        [DisplayName("Tem Palavra-Chave")]
        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }
        
        [DisplayName("Número Telefone")]
        public string PhoneNumber { get; set; }
        
        public bool TwoFactor { get; set; }
        
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "A {0} tem de conter pelo menos {2} carateres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [DisplayName("Nova Palavra-Chave")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Confirmar Nova Palavra-Chave")]
        [Compare("NewPassword", ErrorMessage = "A nova palavra-chave e a sua confirmação não correspondem.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Palavra-Chave Antiga")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} tem de conter pelo menos {2} carateres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [DisplayName("Nova Palavra-Chave")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Confirmar Nova Palavra-Chave")]
        [Compare("NewPassword", ErrorMessage = "A nova palavra-chave e a sua confirmação não correspondem.")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [DisplayName("Número Telefone")]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [DisplayName("Código")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [DisplayName("Número Telefone")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        [DisplayName("Fornecedor Selecionado")]
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}