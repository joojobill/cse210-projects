using System;

public class Address 
{
    // Private member variables
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Method to return the full address as a formatted string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}