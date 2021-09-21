using System;
using TddSession;

namespace TddSessionTest.Setup
{
  public class CustomerBuilder
  {
    public CustomerBuilder()
    {
      _name = string.Empty;
      _dateOfBirth = null;
      _surname = string.Empty;
      _isVeteran = false;
    }

    private string _name { get; set; }
    private DateTime? _dateOfBirth { get; set; }
    private string _surname { get; set; }
    private bool _isVeteran { get; set; }

    public CustomerBuilder WithDateOfBirth(DateTime? dateTime)
    {
      _dateOfBirth = dateTime;
      return this;
    }

    public CustomerBuilder WithVeteranValue(bool veteran)
    {
      _isVeteran = veteran;
      return this;
    }

    public CustomerBuilder WithName(string name)
    {
      _name = name;
      return this;
    }

    public CustomerBuilder WithSurname(string surName)
    {
      _surname = surName;
      return this;
    }

    public Customer Build()
    {
      return new Customer(_name, _surname, _isVeteran, _dateOfBirth);
    }
  }
}