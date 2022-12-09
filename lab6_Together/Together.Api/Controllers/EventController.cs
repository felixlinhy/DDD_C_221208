namespace Together.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Together.Contract.Controller;

[ApiController]
[Route("api")]
public class EventController:ControllerBase
{
    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        AddEventResponse res = new AddEventResponse(
            Guid.NewGuid(),request.name,
            request.coordinator,request.place,request.lat,
            request.lng,request.fee
        );
        return Ok(res);
    }
    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        QueryEventResponse res = new QueryEventResponse(
            "name","coord","tpe",0.5f,0.5f,300
        );
        QueryEventResponse[] events=new QueryEventResponse[] {res,res,res};

        return Ok(events);
    }

}