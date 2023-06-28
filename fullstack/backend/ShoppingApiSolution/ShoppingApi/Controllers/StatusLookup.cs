namespace ShoppingApi.Controllers;

public class StatusLookup : ILookUpTheStatus
{
    public Task<GetStatusResponse> GetCurrentStatusAync()
    {
        var response = new GetStatusResponse
        {
            Message = "Looks Good Here",
            LastChecked = DateTime.Now,
        };
        return Task.FromResult(response);
    }
}
