public class Computer:ICloneable
{
    string id;
    string title;
    string color;
    string country;
    string company;
    uint price;
    byte quantity;
    byte expired;
    bool OS_setup;

    public Computer(string id, string title, string color, string country,
      string company, uint price, byte quantity,
      byte expired, bool OS_setup)
    {
        this.id = id;
        this.title = title;
        this.color = color;
        this.country = country;
        this.company = company;
        this.price = price;
        this.quantity = quantity;
        this.expired = expired;
        this.OS_setup = OS_setup;
    }
    public override string ToString()
    {
        return $"Computer({id}, {title}, {color}, {country}, {company}, {price}, {quantity}, {expired}, {OS_setup})";
    }
    public bool find(string kw){
        return title.IndexOf(kw)>=0 || country.Equals(kw);
    }
    public bool find(uint fr, uint to){
        return price>=fr && quantity<=to;
    }

  public object Clone()
  {
    return new Computer(id, title, color, country, company, 
        price, quantity, expired, OS_setup);
  }
}