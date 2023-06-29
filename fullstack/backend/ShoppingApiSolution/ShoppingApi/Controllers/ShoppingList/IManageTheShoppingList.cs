namespace ShoppingApi.Controllers.ShoppingList;

public interface IManageTheShoppingList
{
    Task<ShoppingListItemModel> AddItemAsync(ShoppingListItemModel model);
    Task<CollectionResponse<ShoppingListItemModel>> GetShoppingListAsync();
    Task<bool> MarkAsPurchasedAsync(ShoppingListItemModel request);
}