using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace tutorial_cognito_authentication.Controllers;

[Route("[controller]/[action]")]
public class ValuesController : ControllerBase
{
    // GET api/values
    [HttpGet]
    [Authorize]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    
    // GET api/values/5
    
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
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