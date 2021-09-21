using System;
using System.Collections.Generic;

namespace TddSession
{
  public class ShoppingBasket : IShoppingBasket

  {
    private readonly IEnumerable<IDiscountRepository> _discountRepository;
    private readonly List<ShoppingItem> _shoppingItems;
    private Customer _customer;

    public ShoppingBasket(
      List<ShoppingItem> shoppingItems,
      IEnumerable<IDiscountRepository> discountRepository,
      Customer customer)
    {
      _shoppingItems = shoppingItems;
      _discountRepository = discountRepository;
      _customer = customer;
    }

    public ShoppingBasket()
    {
    }

    public IEnumerable<ShoppingItem> ShoppingItems => _shoppingItems;

    public void AddCustomer(Customer customer)
    {
      _customer = customer;
    }

    public void AddShoppingItems(IEnumerable<ShoppingItem> shoppingItems)
    {
      _shoppingItems.AddRange(shoppingItems);
    }

    /* Compatibles:
     * ElderRule: Si el cliente tiene más de 65 años, se aplica un descuento del 5% del total
     * VeteranRule: Si el cliente es veterano, se aplica un descuento del 7% del total
     * 3x2Rule: Si hay 3 items del mismo tipo, se ofrece el más barato.
     * 
     */

    /* Restricciones:
     * No puede aplicarse la promoción 3x2 sobre los items luxury
     * Si el cliente no es Veterano no se puede aplicar la promoción 3x2 Premium.
     * Las promociones 3X2 sobre los productos se aplican siempre y cuando existan en el repository de DiscountRepository
     */

    public decimal CalculateTotal()
    {
      throw new NotImplementedException();
    }

    public decimal GetTotalDiscount()
    {
      throw new NotImplementedException();
    }
  }
}