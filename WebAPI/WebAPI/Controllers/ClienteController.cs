using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult CriarCliente(ClienteDto clienteDto)
        {
        var lista = new List<ClienteDto>();
        lista.Add(clienteDto);
        return CreatedAtAction(nameof(CriarCliente), Guid.NewGuid());

        }

    }
}
