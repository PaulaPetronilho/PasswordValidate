# README - Validador de Senha

## Introdução
Este é um projeto .NET que expõe uma API web para validar senhas de acordo com critérios específicos. A API retorna um booleano indicando se a senha é válida ou não, juntamente com uma lista de erros, caso a senha seja inválida.

## Executando o Projeto
Para executar o projeto, siga os passos abaixo:

1. Certifique-se de ter o ambiente .NET configurado em sua máquina.
2. Clone o repositório em seu ambiente local.
3. Abra a solução no Visual Studio ou em sua IDE preferida.
4. Compile o projeto.
5. Execute o projeto.

## Detalhes da Solução

### Estrutura do Projeto
O projeto consiste em três partes principais:

- **ValidarSenha.Controllers**: Este namespace contém o controlador da API `SenhaController`, responsável por expor a API para validar senhas.
- **ValidarSenha.Models**: Aqui estão definidos os modelos utilizados pela API, incluindo o modelo `ResultadoModel` para representar o resultado da validação da senha.
- **ValidarSenha.Services**: Contém a lógica de validação da senha no `SenhaValidator`.

### Decisões de Projeto
- **Abstração e Acoplamento**: O projeto foi estruturado de forma a separar claramente a lógica de validação da senha em um serviço (`SenhaValidator`), mantendo o controlador (`SenhaController`) com a responsabilidade de lidar com as requisições HTTP.
- **Extensibilidade e Coesão**: A estrutura do projeto permite fácil extensão para incluir novas regras de validação de senha. Cada regra é verificada de forma separada no `SenhaValidator`, o que facilita a adição de novas validações.
- **Design de API**: A API foi projetada para ser simples e intuitiva. Ela aceita uma requisição POST com a senha a ser validada e retorna um resultado booleano indicando se a senha é válida, juntamente com uma lista de erros, se aplicável.
- **Clean Code**: O código foi organizado de forma clara e legível, seguindo as melhores práticas de codificação.

### Testando a API pelo Postman
Para testar a API usando o Postman:

1. Certifique-se de que o projeto está em execução.
2. Abra o Postman e crie uma nova solicitação POST para o endpoint `http://localhost:porta/api/senha`, onde `porta` é a porta em que o projeto está sendo executado.
3. Selecione a opção Body da solicitação, o "raw" e o formato como "JSON".
4. Envie a senha a ser validada como um texto - Sem usar {}.
5. Envie a solicitação e observe a resposta da API.

## Considerações Finais
Este projeto foi desenvolvido como parte de um desafio de validação de senhas. Caso haja alguma dúvida ou sugestão de melhoria, não hesite em entrar em contato.

Obrigado por revisar este projeto!
