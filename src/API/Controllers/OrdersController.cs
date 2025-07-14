using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class OrdersController : ApiControllerBase
{
    [HttpPost("Create")]
    public ActionResult Create()
    {
        throw new NotImplementedException();
    }

    [HttpPost("{id}/complete")]
    public ActionResult Complete(string id)
    {
        throw new NotImplementedException();
    }
}
