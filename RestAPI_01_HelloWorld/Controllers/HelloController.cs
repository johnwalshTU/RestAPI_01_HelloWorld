using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

/*
 * Quick explanation re return of OK() below
 A Web API controller action can return any of the following:
see https://learn.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-7.0
The IActionResult types represent various HTTP status codes 
It allows .Net to moves common logic for creating HTTP responses into separate classes (i.e classes that implement IActionResult who create HttpResponseMessage types as needed )
It also makes the code more readable by providing methods names that are intuitive e.g return Ok() returns HTTP 200 response (200 means all ok)
*/




namespace RestAPI_01_HelloWorld.Controllers
{
    [Route("api/[controller]")]    //route to get us to this controller is api/Hello
    [ApiController]
    public class HelloController : ControllerBase
    {

        //Obnly 1 method here
        //Controller route above is  /api/[controller] which means route to this contoller is api/Hello
        //There is only i method here
        //I didnt specify HTTPGet or HTTPPost etc.. so default is HTTPGet
        //So url http://localhost:5145/api/hello?name=John will get us to this method
        
        public IActionResult GetHelloGreeting(string name)               // GET
        {
            return Ok("Hello there " + name + ", welcome to the ASP.Net Web API");      // 200 OK
        }

        // return data serialised as XML or JSON or GSON depending on Accept header (default is json)
        // sample URLs to invoke
        //  http://localhost:5145/api/hello?name=John

        //Note : Validation
        //Validation is build in (NoContentResult on that later)
        //Try :  http://localhost:5145/api/hello?name=John
        //You will get a 400 error stating name parameter is required
    }
}
