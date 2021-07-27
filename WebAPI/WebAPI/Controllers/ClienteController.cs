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
        static List<ClienteDto> clientes = new List<ClienteDto>();  //com tipo static só irá perder os dados quando o programa fechar.
       
        [HttpGet]    //[HttpGet(template: "listar")]
        public ActionResult<IEnumerable<ClienteDto>> ObterClientes() 
        {
            //var lista = new List<ClienteDto>();
            //lista.Add(item: new ClienteDto() { Nome = "Cristiano"});
            //lista.Add(item: new ClienteDto() { Nome = "Weiden" });
            //return Ok(lista);

            return Ok(clientes);  
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
                
                clientes.Add(clienteDto);
                return CreatedAtAction(nameof(CriarCliente), Guid.NewGuid());
                
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }

        [HttpDelete]
        public ActionResult Remover(string cpf)
        {
            foreach(var cliente in clientes)
            {
                if (cpf == cliente.Cpf)
                {
                    clientes.Remove(cliente);
                    break;
                }
            }

            return Ok();
        }

        



    }
}
