namespace GitProgram
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Number: {Number}";
        }
    }
}
