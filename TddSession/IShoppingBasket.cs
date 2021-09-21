using System.Collections.Generic;

namespace TddSession
{
  public interface IShoppingBasket
  {
    decimal CalculateTotal();
    decimal GetTotalDiscount();
    void AddCustomer(Customer customer);
    void AddShoppingItems(IEnumerable<ShoppingItem> shoppingItems);
  }
}