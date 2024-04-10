using GitProgram;

List<Contact> contacts = [];

AddContact(contacts);
ShowContacts(contacts);

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