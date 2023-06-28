namespace ShoppingApi.Models;

public record GetStatusResponse
{
    public string Message { get; set; } = string.Empty;

    public DateTime LastChecked { get; set; }
}
