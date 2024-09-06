//https://github.com/thanhdnh/Ex01_Store_Mana
public class Program
{
    public static void PrintComputers(List<Computer> computers){
        foreach(Computer computer in computers)
            Console.WriteLine(computer);
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        Store store = new Store();
        store.computers.Add(new Computer("Com01", "Dell XPS 2020", 
        "white", "Indonesia", "Dell", 25000000, 23,
        12, true));
        store.computers.Add(new Computer("Com02", "LG gram 2022", 
        "black", "Vietnam", "LG", 27000000, 17,
        12, true));
        PrintComputers(store.computers);

        Console.ReadKey();
    }
}