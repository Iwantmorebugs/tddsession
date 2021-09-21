using System;

namespace TddSession
{
  public class Customer
  {
    public Customer(string name, string surname, bool isVeteran, DateTime? dateOfBirth)
    {
      Name = name ?? throw new ArgumentNullException(nameof(name));
      Surname = surname ?? throw new ArgumentNullException(nameof(surname));
      IsVeteran = isVeteran;
      DateOfBirth = dateOfBirth;
    }

    public string Name { get; }
    public DateTime? DateOfBirth { get; set; }
    public string Surname { get; }
    public bool IsVeteran { get; set; }
  }
}