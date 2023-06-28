namespace ShoppingApi.Controllers;

public interface ILookUpTheStatus
{
    Task<GetStatusResponse> GetCurrentStatusAsync();
}