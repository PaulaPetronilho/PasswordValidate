// Importação da biblioteca necessária
using System.Collections.Generic;

namespace ValidarSenha.Models
{
    public class ResultadoModel
    {
        // Indica se a senha é válida ou não
        public bool IsValid { get; set; }
        // Lista de mensagens de erro relacionadas à validação da senha
        public List<string> Erros { get; set; }
    }
}