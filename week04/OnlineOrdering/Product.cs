using System;

public class Product
{
    private static readonly Random _rng = new Random();
    private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; //! Got this line from chatGPT

    private string _productName;
    private string _productId;
    public string ProductId => _productId;
    private double _price;
    private int _quantity;
    private double _totalCost;

    public void setQuantity(int newQuantity)
    {
        _quantity = newQuantity;
    }

    //! Got this method from chatGPT.
    private string GenerateProductId()
    {
        char[] id = new char[7];
        for (int i = 0; i < id.Length; i++)
        {
            id[i] = _chars[_rng.Next(_chars.Length)];
        }
        return new string(id);
    }

    public Product(string productName, double price)
    {
        _productName = productName;
        _productId = GenerateProductId();
        _price = price;
        _quantity = 1;
    }
    
    public Product(string productName, double price, int quantity)
    {
        _productName = productName;
        _productId = GenerateProductId();
        _price = price;
        _quantity = quantity;
    }
    
    public double GetCost()
    {
        _totalCost = (double) _price * _quantity; // ? Casted explicitly to avoid issues.
        return _totalCost;
    }


    public string GetInfo()
    {
        return $"Product ID: {_productId} || Product Name: {_productName} || Quantity: {_quantity} || Cost: ${_price:F2} || Total Cost: ${GetCost():F2}";
    }
}