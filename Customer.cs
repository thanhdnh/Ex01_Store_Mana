public class Customer
{
    private string name;
    private string address;
    private string phone;

    public Customer(string name, string address, string phone)
    {
        this.name = name;
        this.address = address;
        this.phone = phone;
    }
    public Computer order(Computer computer){
        Computer mycom = (Computer)computer.Clone();
        return mycom;
    }

}