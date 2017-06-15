using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace WebAPITemplate.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("somemethod/{customerId}")]
        public IEnumerable<String> SomeMethod(int customerId)
        {
            return new List<string> { "a", "b", "c" };
        }

        [Route("someothermethod")]
        public IEnumerable<String> SomeOtherMethod([FromBody] dynamic complexType)
        {

            return new List<string> { complexType.somevalue.Value, "2", "3" };
        }

        [HttpPost]
        [Route("someinputmethod")]
        public HttpResponseMessage SomeInputMethod([FromBody]InputBody inputBody)
        {
            var x = inputBody.headerData;
            return new HttpResponseMessage(System.Net.HttpStatusCode.Accepted);
        }

        public class InputBody
        {
            public Dictionary<string, string> headerData { get; set; }
            public Dictionary<string, string> rowData { get; set; }
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
