using System;
using System.Collections.Generic;

class Order
{
    private Customer _customer;
    private List<Product> _products;
    private string _packingLabel;
    private string _shippingLabel;
    private double _totalPrice;
    private double _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    
    public void AddNewProduct(Product product)
    {
        _products.Add(product);
    }

    public bool RemoveProduct(string productId)
    {
        if (_products == null) return false;
        var product = _products.Find(p => p.ProductId == productId); // ! Learnt this from chatGPT :D
        if (product == null) return false;
        return _products.Remove(product);
    }
    
    public double ComputeTotalPrice()
    {
        _totalPrice = 0.0;
        foreach (Product product in _products)
        {
            _totalPrice += product.GetCost();
        }
        return _totalPrice;
    }
    public string GetPackingLabel()
    {
        _packingLabel = $"=============\nPacking Label:\n=============\n||-- Customer Name: {_customer.GetFullName()}\n||-- Products:\n";
        foreach (Product product in _products)
        {
            _packingLabel += $"\t=>{product.GetInfo()}";
            _packingLabel += "\n";
        }
        _packingLabel += $"||-- Total Cost: ${ComputeTotalPrice():F2}";
        return _packingLabel;
    }
    
    public string GetShippingLabel()
    {
        Address shippingAddress = new Address("42B Housten Building", "Skyline City", "Texas", "USA");
        _shippingCost = 0.0;
        if (_customer.livesInUSA())
        {
            _shippingCost = 5.0;
        }
        else
        {
            _shippingCost = 35.0;
        }
        _shippingLabel = $"==============\nShipping Label:\n==============\n||-- Customer Name: {_customer.GetFullName()}\n||-- Customer Address: {_customer.GetAddress()}\n||-- Shipping Address: {shippingAddress.GetFullAddress()}\n||-- Shipping Cost: ${_shippingCost}\n||-- Number Of Products: {_products.Count}\n||-- Total Cost: ${ComputeTotalPrice():F2}\n||-- Total Cost + Shipping Cost: ${ComputeTotalPrice() + _shippingCost:F2}";
        return _shippingLabel;
    }
}
