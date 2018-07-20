using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DividerContest.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public string Get(decimal a, decimal b)
        {
            return (a / b).ToString();
        }
    }
}
