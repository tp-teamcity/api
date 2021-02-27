using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpperController : ControllerBase
    {
        private readonly ILogger<UpperController> _logger;

        public UpperController(ILogger<UpperController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public string ToUpper()
        {
            
            string stringToUpper = string.Empty;
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                stringToUpper = reader.ReadToEndAsync().Result;
            }
            return lib.Uppercase.ToUpper(stringToUpper) ;
        }
    }
}