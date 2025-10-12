using System.ComponentModel.DataAnnotations;

namespace GroovEcoBlazor1.Models
{
public class ContactModel
{
[Required(ErrorMessage = "Le nom est requis")]
public string FullName { get; set; } ="";

[Required(ErrorMessage = "L'email est requis")]
[EmailAddress(ErrorMessage = "Format d'email invalide")]
public string Email { get; set; } ="";

public string Phone { get; set; } ="";

[Required(ErrorMessage = "Le message est requis")]
[StringLength(1000, ErrorMessage = "Le message est trop long")]
public string Message { get; set; } ="";
}
}
