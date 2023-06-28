using Microsoft.EntityFrameworkCore;
using ShoppingApi.Data;

namespace ShoppingApi.Controllers;

public class StatusLookup : ILookUpTheStatus
{
    private readonly ShoppingDataContext _context;

    public StatusLookup(ShoppingDataContext context)
    {
        _context = context;
    }

    public async Task<GetStatusResponse> GetCurrentStatusAync()
    {
        var savedSatus = await _context.StatusMessages.OrderBy(m => m.LastChecked).FirstOrDefaultAsync();

        if (savedSatus is null) 
        {
            //if empty
            var entityToSave = new StatusEntity
            {
                LastChecked = DateTimeOffset.Now,
                Message = "looks good",
            };
            _context.StatusMessages.Add(entityToSave);
            await _context.SaveChangesAsync();
        }
        else
        {
            //check if stale
        }
        var response = new GetStatusResponse
        {
            Message = "Looks Good Here",
            LastChecked = DateTimeOffset.Now,
        };
        return Task.FromResult(response);
    }
}
