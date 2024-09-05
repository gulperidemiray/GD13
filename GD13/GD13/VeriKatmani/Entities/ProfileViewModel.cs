using System.ComponentModel.DataAnnotations;

public class ProfileViewModel
{
    [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "LinkedIn URL gereklidir.")]
    [Url(ErrorMessage = "Geçerli bir LinkedIn URL'si giriniz.")]
    public string LinkedInUrl { get; set; }

    [Required(ErrorMessage = "GitHub URL gereklidir.")]
    [Url(ErrorMessage = "Geçerli bir GitHub URL'si giriniz.")]
    public string GitHubUrl { get; set; }
}
