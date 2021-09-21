using System;
using TddSession;

namespace TddSessionTest.Setup
{
  public class TestSetup
  {
    public TestSetup()
    {
      CustomerNotVeteran = customerNotVeteran;
      CustomerVeteran = customerVeteran;
      IsVeteran = isVeteran;
      BasicItem = basicItem;
      StandardType = standardType;
      PremiumType = premiumType;
      LuxuryType = luxuryType;
      CustomerBuilder = new CustomerBuilder();
      ShoppingBasketBuilder = new ShoppingBasketBuilder();
    }

    protected DateTime BirthDateOldCustomer = DateTime.Now.AddYears(-65);
    protected DateTime BirthDateYoungCustomer = DateTime.Now.AddYears(-35);
    protected Customer CustomerNotVeteran;
    protected Customer CustomerVeteran;
    protected bool IsVeteran = true;
    protected ShoppingItem BasicItem;
    protected ShoppingItem StandardType;
    protected ShoppingItem PremiumType;
    protected ShoppingItem LuxuryType;
    protected CustomerBuilder CustomerBuilder;
    protected ShoppingBasketBuilder ShoppingBasketBuilder;


  }
}