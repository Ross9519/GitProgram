using GitProgram;

List<Contact> contacts = 
[
    new("Gianluca", "5284562945"), 
    new("Pippo", "3937505154"),
    new("Pluto", "3047592385"),
    new("Pippo", "5849640234")
];

AddContact(contacts);
ShowContacts(contacts);
FindContact(contacts);



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

    List<Contact> foundContacts = contacts.FindAll(contact => contact.Name.ToLower().Equals(name.ToLower()));
    
    Console.WriteLine("Contacts Found:");
    foreach (var item in foundContacts)
    {
        Console.WriteLine(item);
    }
}