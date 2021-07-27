using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class ClienteDto
    {
        [Required]  //Para tratar obrigatoriedade de campos.
        public string Nome { get; set; }
        public string Cpf { get; set;  }
        //public int  Idade { get; set; }
     }
}
