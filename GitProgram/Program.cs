using GitProgram;

List<Contact> contacts = [];

AddContact(contacts);

static void AddContact(List<Contact> contacts)
{
    Console.WriteLine("New Contact:");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Number: ");
    string number = Console.ReadLine();

    Contact contact = new(name, number);
    contacts.Add(contact);

}