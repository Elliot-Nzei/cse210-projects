using System;
using System.Collections.Generic;

class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Calculate the total cost for this product
    public double CalculateTotalCost()
    {
        return price * quantity;
    }

    // Getters for private fields
    public string Name => name;
    public int ProductId => productId;
}