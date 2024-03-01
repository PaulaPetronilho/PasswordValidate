// Importação da biblioteca necessária
using System.Collections.Generic;
using System.Linq;
using ValidarSenha.Models;

namespace ValidarSenha.Services
{
    public class SenhaValidator
    {
        // Método para verificar se uma senha é valida ou não
        public ResultadoModel ValidarSenha(string senha)
        {
            // Instanciando o model do resultado
            ResultadoModel model = new ResultadoModel();
            // Inicialização da lista de erros
            model.Erros = new List<string>();

            // Verifica se a senha possui nove ou mais caracteres
            if (senha.Length < 9)
            {
                model.IsValid = false;
                model.Erros.Add("A senha deve ter nove ou mais caracteres.");
            }
            // Verifica se a senha possui ao menos 1 dígito
            if (!senha.Any(char.IsDigit))
            {
                model.IsValid = false;
                model.Erros.Add("A senha deve conter ao menos 1 dígito.");
            }
            // Verifica se a senha possui ao menos 1 letra minúscula
            if (!senha.Any(char.IsLower))
            {
                model.IsValid = false;
                model.Erros.Add("A senha deve conter ao menos 1 letra minúscula.");
            }
            // Verifica se a senha possui ao menos 1 letra maiúscula
            if (!senha.Any(char.IsUpper))
            {
                model.IsValid = false;
                model.Erros.Add("A senha deve conter ao menos 1 letra maiúscula.");
            }
            // Verifica se a senha possui ao menos 1 caractere especial
            if (!senha.Any(c => "!@#$%^&*()-+".Contains(c)))
            {
                model.IsValid = false;
                model.Erros.Add("A senha deve conter ao menos 1 caractere especial.");
            }
            // Verifica se a senha não possui caracteres repetidos
            if (senha.Distinct().Count() != senha.Length)
            {
                model.IsValid = false;
                model.Erros.Add("A senha não pode conter caracteres repetidos.");
            }
            // Verifica se a senha possui espaços em branco
            if (senha.Contains(" "))
            {
                model.IsValid = false;
                model.Erros.Add("A senha não pode conter espaços em branco.");
            }
            // Se houver erros, a senha é inválida
            if (model.Erros.Count > 0)
            {
                return (model);
            }
            else
            {
                // Se não houver erros, a senha é válida
                model.IsValid = true;
                return (model);
            }
        }
    }
}