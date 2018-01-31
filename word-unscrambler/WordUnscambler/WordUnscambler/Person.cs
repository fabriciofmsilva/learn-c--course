namespace WordUnscambler
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string argFirstName, string argLastName)
        {
            FirstName = argFirstName;
            LastName = argLastName;
        }
    }
}
