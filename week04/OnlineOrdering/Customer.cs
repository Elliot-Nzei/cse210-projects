class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Check if the customer lives in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Getter for the name
    public string Name => name;
    public Address Address => address;
}