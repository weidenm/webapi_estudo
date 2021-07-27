using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route(template: "api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        [HttpGet(template: "listar")]
        public ActionResult<IEnumerable<ClienteDto>> ObterClientes() 
        {
            var lista = new List<ClienteDto>();
            lista.Add(item: new ClienteDto() { Nome = "Cristiano"});
            lista.Add(item: new ClienteDto() { Nome = "Weiden" });
            return Ok(lista);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]  //Define tipo de dados para consumir API.
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult CriarCliente(ClienteDto clienteDto)
        {
            try
            {
                //var lista = new List<ClienteDto>();
                //throw new Exception("Erro ao salvar no banco de dados!");
                //lista.Add(clienteDto);
                //return CreatedAtAction(nameof(CriarCliente), Guid.NewGuid());

                return BadRequest();
                
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Erro");
            }
            
        }

    }
}
