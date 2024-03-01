// Importação da biblioteca necessária
using System.Web.Http;
using ValidarSenha.Models;
using ValidarSenha.Services;

namespace ValidarSenha.Controllers
{
    public class SenhaController : ApiController
    {
        // POST api/senha
        [HttpPost]
        public IHttpActionResult Post([FromBody] string senha)
        {
            // Instanciando o SenhaValidator
            SenhaValidator senhaValidator = new SenhaValidator();
            // Instanciando o model do resultado
            ResultadoModel model = new ResultadoModel();
            // Valida a senha usando o SenhaValidator
            model = senhaValidator.ValidarSenha(senha);

            // Caso a senha seja válida
            if (model.IsValid)
            {
                return Ok(model);
            }
            // Caso a senha não seja válida
            return Ok(model.Erros);
        }
    }
}
