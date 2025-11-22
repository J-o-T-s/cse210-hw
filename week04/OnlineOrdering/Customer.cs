using System;

class Customer
{
    private string _firstName;
    private string _lastName;
    private Address _address;

    public Customer(string firstName, string lastName, Address address)
    {
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
    }
    
    public bool livesInUSA()
    {
        if (_address.CountryIsUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }


    public string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }
}
