using System.Collections.Generic;

namespace TddSession
{
  public class DiscountRepository : IDiscountRepository
  {
    private static List<ItemType> _discountApplicableItems;

    public DiscountRepository()
    {
      _discountApplicableItems = new List<ItemType>();
    }

    public IEnumerable<ItemType> GetDiscountApplicableItems()
    {
      return _discountApplicableItems;
    }

    public bool AddApplicableItem(ItemType itemType)
    {
      if (!_discountApplicableItems.Contains(itemType))
      {
        _discountApplicableItems.Add(itemType);
        return true;
      }

      return false;
    }

    public void RemoveApplicableItem(ItemType itemType)
    {
      if (_discountApplicableItems.Contains(itemType)) _discountApplicableItems.Remove(itemType);
    }
  }
}