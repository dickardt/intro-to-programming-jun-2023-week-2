using Microsoft.AspNetCore.Mvc;

namespace ShoppingApi.Controllers;

public class StatusController : ControllerBase
{

    private readonly ILookUpTheStatus _statusLookup;

    public StatusController(ILookUpTheStatus statusLookup)
    {
        _statusLookup = statusLookup;
    }

    [HttpGet("/status")]
    public async Task<ActionResult> GetTheStatus()
    {
        GetStatusResponse response = await _statusLookup.GetCurrentStatusAsync();
        return Ok(response);
    }
}

