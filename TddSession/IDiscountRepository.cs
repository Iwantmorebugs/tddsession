using System.Collections.Generic;

namespace TddSession
{
  public interface IDiscountRepository
  {
    IEnumerable<ItemType> GetDiscountApplicableItems();
    bool AddApplicableItem(ItemType itemType);
    void RemoveApplicableItem(ItemType itemType);
  }
}