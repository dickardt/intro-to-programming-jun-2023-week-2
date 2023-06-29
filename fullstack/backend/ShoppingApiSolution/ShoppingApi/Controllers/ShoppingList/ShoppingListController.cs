using System.Security.Cryptography;

namespace ShoppingApi.Controllers.ShoppingList;

public class ShoppingListController : Controller


{

    private readonly IManageTheShoppingList _shoppingListManager;

    public ShoppingListController(IManageTheShoppingList shoppingListManager)
    {
        _shoppingListManager = shoppingListManager;
    }

    [HttpGet("/shopping-list")]
    public async Task<ActionResult> GetShoppingList()
    {
        CollectionResponse<ShoppingListItemModel> response = await _shoppingListManager.GetShoppingListAsync();
        return Ok(response);
    }

    [HttpPost("/shopping-list")]
    public async Task<ActionResult> AddShoppingListItem([FromBody]ShoppingListItemModel model)
    {
        if (ModelState.IsValid)
        {
            ShoppingListItemModel response = await _shoppingListManager.AddItemAsync(model);
            return Ok(response);
        }
        else
        {
            return BadRequest(ModelState);
        }
    }

    [HttpPut("/completed-shopping-items/{id}")]
    public async Task<ActionResult> MarkItemAsPurchased(string id, [FromBody]ShoppingListItemModel request)
    {
        if(id != request.Id)
        {
            return BadRequest();
        }
        bool wasUpdated = await _shoppingListManager.MarkAsPurchasedAsync(request);
        if (wasUpdated)
        {
            return NoContent();
        }
        else
        {
            return NotFound();
        }
    }

}
