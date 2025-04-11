using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api_Autentication.Filters
{
    public class ApiExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<ApiExceptionFilter> _logger;

        public ApiExceptionFilter(ILogger<ApiExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            int statusCode = StatusCodes.Status500InternalServerError;
            string mensagem = "Ocorreu um erro interno no servidor";

            if (context.Exception is ArgumentException)
            {
                statusCode = StatusCodes.Status400BadRequest;
                mensagem = "Parâmetros Inválidos na solicitação";
            }
            else if (context.Exception is NotFound)
            {
                statusCode = StatusCodes.Status404NotFound;
                mensagem = "Não encontrado";
            }

            _logger.LogError(context.Exception, $"Ocorreu uma exceção não tratada: Status Code {statusCode}");
            context.Result = new ObjectResult(mensagem)
            {
                StatusCode = statusCode
            };

        }
    }
}
