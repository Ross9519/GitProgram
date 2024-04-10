using GitProgram;

List<Contact> contacts = 
[
    new("Gianluca", "5284562945"), 
    new("Pippo", "3937505154"),
    new("Pluto", "3047592385")
];

string cmd;
do
{
    Console.WriteLine("Program started");
    do
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("Add a contact [A], Show all contacts [S], Find a contact [F], Remove a contact [R], Quit [Q]");
        cmd = Console.ReadLine().ToUpper();
    } while (cmd != "A" || cmd != "S" || cmd != "F" || cmd != "R" || cmd != "Q");
    SelectMethod(cmd, contacts);
} while (cmd != "Q");


static void SelectMethod(string cmd, List<Contact> contacts)
{
    switch(cmd)
    {
        case "A":
            AddContact(contacts);
            break;
        case "S":
            ShowContacts(contacts);
            break;
        case "F":
            FindContact(contacts);
            break;
        case "R":
            RemoveContact(contacts);
            break;
        case "Q":
            Console.WriteLine("Bye");
            break;
    }
}

static void AddContact(List<Contact> contacts)
{
    string name;
    string number;
    Console.WriteLine("New Contact:");
    do
    {
        Console.Write("Name: ");
        name = Console.ReadLine();
    } while (string.IsNullOrEmpty(name));
    do
    {
        Console.Write("Number: ");
        number = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(number));

    Contact contact = new(name, number);
    contacts.Add(contact);

}

static void ShowContacts(List<Contact> contacts)
{
    Console.WriteLine("Here all the contacts in contact list");

    foreach (var item in contacts)
    {
        Console.WriteLine(item);
    }
}

static void FindContact(List<Contact> contacts)
{
    Console.WriteLine("Let's find a contact in contact list:");
    string name;
    do
    {
        Console.Write("Name: ");
        name = Console.ReadLine();
    } while (string.IsNullOrEmpty(name));

    Contact foundContact = contacts.Find(contact => contact.Name.ToLower().Equals(name.ToLower()));

    if (foundContact != null)
    {
        Console.WriteLine("Contact Found:");
        Console.WriteLine(foundContact);
    }
    else
    {
        Console.WriteLine("Contact Not Found");
    }
}

static void RemoveContact(List<Contact> contacts)
{
    Console.WriteLine("Let's remove a contact in contact list:");
    string name;
    do
    {
        Console.Write("Name: ");
        name = Console.ReadLine();
    } while (string.IsNullOrEmpty(name));

    Contact contact = contacts.Find(contact => contact.Name.ToLower().Equals(name.ToLower()));
    if (contact != null)
    {
        contacts.Remove(contact);
        Console.WriteLine("Contact Removed");
    }
    else
    {
        Console.WriteLine("Contact Not Found");
    }
}