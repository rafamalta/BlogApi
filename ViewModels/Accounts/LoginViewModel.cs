﻿using System.ComponentModel.DataAnnotations;

namespace BlogApi.ViewModels.Accounts;

public class LoginViewModel
{
    [Required(ErrorMessage = "O e-mail é obrigatório!")]
    [EmailAddress(ErrorMessage = "E-mail inválido!")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Informe a senha!")]
    public string Password { get; set; }
}
