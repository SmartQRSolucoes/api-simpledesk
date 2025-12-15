using Application.Phaynell.Interfaces.Services;
using Domain.Phaynell.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("SmartQR/Phaynell")]
    public class PhaynellController : ControllerBase
    {
        private readonly IPhaynellService _phaynellService;

        public PhaynellController(IPhaynellService phaynellService)
        {
            _phaynellService = phaynellService;
        }

        //[HttpGet("GetOfs")]
        //public async Task<ActionResult<string>> GetOfs([Required][FromQuery] string serie, [Required][FromQuery] string doc_company)
        //{
        //    try
        //    {
        //        var result = await _phaynellService.GetOfs();

        //        if (string.IsNullOrEmpty(result))
        //            return BadRequest($"Nao foi possivel encontrar os pedidos no banco de dados.");
        //        else
        //            return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.StatusCode = 400;
        //        return Content($"Nao foi possivel encontrar os pedidos no banco de dados. Erro: {ex.Message}");
        //    }
        //}

        //[HttpGet("GetOfsAcompanhamnetos")]
        //public async Task<ActionResult<string>> GetOfsAcompanhamnetos([Required][FromQuery] string serie, [Required][FromQuery] string doc_company)
        //{
        //    try
        //    {
        //        var result = await _phaynellService.GetOfsAcompanhamentos();

        //        if (string.IsNullOrEmpty(result))
        //            return BadRequest($"Nao foi possivel encontrar os pedidos no banco de dados.");
        //        else
        //            return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.StatusCode = 400;
        //        return Content($"Nao foi possivel encontrar os pedidos no banco de dados. Erro: {ex.Message}");
        //    }
        //}

        /// <summary>
        /// Obter uma Ordem de Fabricação
        /// </summary>
        /// <param name="numero_of">Número da Ordem de Fabricação</param>
        /// <returns>Dados da Ordem de Fabricação</returns>
        /// <response code="200">Sucesso</response>
        /// <response code="404">Não encontrado</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("GetOf")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Of?>> GetOf([Required][FromQuery] Int64 numero_of)
        {
            try
            {
                var result = await _phaynellService.GetOf(numero_of);

                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Content($"Nao foi possivel encontrar os pedidos no banco de dados. Erro: {ex.Message}");
            }
        }

        /// <summary>
        /// Obter os Detalhes de uma Ordem de Fabricação
        /// </summary>
        /// <param name="numero_of">Número da Ordem de Fabricação</param>
        /// <returns>Detalhes da Ordem de Fabricação</returns>
        /// <response code="200">Sucesso</response>
        /// <response code="404">Não encontrado</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("GetOfAcompanhamneto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Of_Acompanhamento?>> GetOfAcompanhamneto([Required][FromQuery] Int64 numero_of)
        {
            try
            {
                var result = await _phaynellService.GetOfAcompanhamento(numero_of);

                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Content($"Nao foi possivel encontrar os pedidos no banco de dados. Erro: {ex.Message}");
            }
        }
    }
}
