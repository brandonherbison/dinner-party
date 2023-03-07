

List <Guest> guests = CreateGuests();


Dictionary<string, List<Guest>> tables = new Dictionary<string, List<Guest>>();
tables.Add("Table 1", new List<Guest>());
tables.Add("Table 2", new List<Guest>());

foreach (var guest in guests)
{
    var table1Occupations = tables["Table 1"].Select(g => g.occupation).ToList();
    if (table1Occupations.Contains(guest.occupation))
    {
        tables["Table 2"].Add(guest);
    }
    else
    {
        tables["Table 1"].Add(guest);
    }
}

foreach (var tableName in tables.Keys)
{
    var tableGuests = tables[tableName];
    Console.WriteLine(tableName);
    foreach (var guest in tableGuests)
    {
        Console.WriteLine($"{guest.name} ({guest.occupation}) {guest.bio}");
    }
}






//create a function that creates and returns a list of guests
static List<Guest> CreateGuests()
{
    //create a list of guests
    List<Guest> guests = new List<Guest>();

    //create a guest
    Guest guest = new Guest();
    guest.name = "Marilyn Monroe";
    guest.occupation = "entertainer";
    guest.bio = "(1926 - 1962) American actress, singer, model";

    //add the guest to the list
    guests.Add(guest);

    //create a guest
    guest = new Guest();
    guest.name = "Abraham Lincoln";
    guest.occupation = "politician";
    guest.bio = "(1809 - 1865) US President during American civil war";

    //add the guest to the list
    guests.Add(guest);

    //create a guest
    guest = new Guest();
    guest.name = "Martin Luther King";
    guest.occupation = "activist";
    guest.bio = "(1929 - 1968)  American civil rights campaigner";

    //add the guest to the list
    guests.Add(guest);

    //create a guest
    guest = new Guest();
    guest.name = "Rosa Parks";
    guest.occupation = "activist";
    guest.bio = "(1913 - 2005)  American civil rights activist";

    //add the guest to the list
    guests.Add(guest);

    //create a guest
    guest = new Guest();
    guest.name = "Peter Sellers";
    guest.occupation = "entertainer";
    guest.bio = "(1925 - 1980) British actor and comedian";

    //add the guest to the list
    guests.Add(guest);

    //create a guest
    guest = new Guest();
    guest.name = "Alan Turing";
    guest.occupation = "computer scientist";
    guest.bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world";

    //add the guest to the list
    guests.Add(guest);

    //create a guest
    guest = new Guest();
    guest.name = "Admiral Grace Hopper";
    guest.occupation = "computer scientist";
    guest.bio = "(1906-1992) - developed early compilers; work on UNIVAC I; popularized the idea of machine-independent programming languages";

    return guests;
} 

public class Guest {
    public string name { get; set; } = default!;
    public string occupation { get; set; } = default!;
    public string bio { get; set; } = default!;
}