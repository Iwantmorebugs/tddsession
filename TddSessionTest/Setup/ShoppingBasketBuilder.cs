using System.Collections.Generic;
using TddSession;

namespace TddSessionTest.Setup
{
  public class ShoppingBasketBuilder
  {
    private readonly IEnumerable<IDiscountRepository> _discountRepository;
    private readonly List<ShoppingItem> _shoppingItems;
    private Customer _customer;

    public ShoppingBasketBuilder()
    {
      _discountRepository = null;
      _customer = null;
      _shoppingItems = new List<ShoppingItem>();
    }

    public ShoppingBasketBuilder WithCustomer(Customer customer)
    {
      _customer = customer;
      return this;
    }

    public ShoppingBasketBuilder WithItems(IEnumerable<ShoppingItem> items)
    {
      _shoppingItems.AddRange(items);
      return this;
    }

    public ShoppingBasket Build()
    {
      var shoppingBasket = new ShoppingBasket();
      shoppingBasket.AddCustomer(_customer);
      shoppingBasket.AddShoppingItems(_shoppingItems);

      return shoppingBasket;
    }
  }
}