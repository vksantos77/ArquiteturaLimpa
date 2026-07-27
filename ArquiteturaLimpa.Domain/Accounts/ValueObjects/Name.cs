using ArquiteturaLimpa.Domain.Shared.ValueObject;

namespace ArquiteturaLimpa.Domain.Accounts.ValueObjects
{
    public sealed record Name : ValueObject
    {
        #region Constructors
        private Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion
        public static Name Create(string firstName, string lastName)
        {
            if (firstName.Length == 0)
            {
                throw new Exception("First name cannot be empty.");
            }
            return new Name(firstName, lastName);
        }
        #region Properties
        public string FirstName{ get; }
        public string LastName { get; }
        #endregion

        #region Operators
        public static implicit operator string(Name name)
        {
            return name.ToString();
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        #endregion
    }
}
