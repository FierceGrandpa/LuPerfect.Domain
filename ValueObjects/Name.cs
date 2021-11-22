namespace LuPerfect.Domain.ValueObjects
{
    public record Name : ValueObject
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Name(string firstName, string lastName)
        {
            if (firstName is null)
                throw new ArgumentNullException(nameof(firstName));
            if (lastName is null)
                throw new ArgumentNullException(nameof(lastName));

            if (firstName == string.Empty)
                throw new ArgumentException($"Обязательный параметр {nameof(firstName)} был пуст.", nameof(firstName));
            if (lastName == string.Empty)
                throw new ArgumentException($"Обязательный параметр {nameof(lastName)} был пуст.", nameof(lastName));

            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}