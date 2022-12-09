namespace Together.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Together.Contract.Controller;
using Together.Application.Services;

[ApiController]
[Route("api")]
public class EventController:ControllerBase
{
    private readonly IEventService eventService;
    public EventController(IEventService eventService)
    {
        this.eventService = eventService;
    }

    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        var result = eventService.add(request.name,
            request.coordinator,request.place,request.lat,
            request.lng,request.fee);
        AddEventResponse res = new AddEventResponse(
            result.Id,result.name,
            result.coordinator,result.place,result.lat,
            result.lng,result.fee
        );
        return Ok(res);
    }
    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        var result = eventService.query(request.lat,request.lng,request.length);
        QueryEventResponse res = new QueryEventResponse(
            "name","coord","tpe",0.5f,0.5f,300
        );
        QueryEventResponse[] events=new QueryEventResponse[] {res,res,res};

        return Ok(events);
    }

}