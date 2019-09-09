using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            int f = 0;
            int s = 1;
            int r = 0;
            string series = "";
            for (int i = 0; i < 10; i++)
            {
                series = series + " " + s.ToString();
                f = s;
                s = r;
                r = s + f;
            }


            return series;
        }

        // POST api/values/7
        [HttpPost]
        public int Post([FromBody] float value)
        {
            int n = 5;
            int a = 2, d = 1;
            int curr_term;
            curr_term = a;       
            // Console.Write(sumOfAP(a, d, n));
            for (int i = 1; i <= n; i++)
            {
                Console.Write(curr_term + " ");
                curr_term += d;
            }
            return curr_term;
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
