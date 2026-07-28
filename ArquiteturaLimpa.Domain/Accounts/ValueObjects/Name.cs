using ArquiteturaLimpa.Domain.Accounts.ValueObjects.Exceptions;
using ArquiteturaLimpa.Domain.Shared.ValueObject;

namespace ArquiteturaLimpa.Domain.Accounts.ValueObjects
{
    public sealed record Name : ValueObject
    {
        #region Constants
        public const int MinLength = 3;
        public const int MaxLength = 60;
        #endregion

        #region Constructors
        private Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion
        
        #region Factories

        public static Name Create(string firstName, string lastName)
        {
            if (firstName.Length <= MinLength)
            {
                throw new InvalidFirstNameLenghtException();
            }
            if (firstName.Length >= MaxLength)
            {
                throw new Exception("First name cannot be empty.");
            }
            if (lastName.Length <= MinLength)
            {
                throw new Exception("First name cannot be empty.");
            }
            if (lastName.Length >= MaxLength)
            {
                throw new Exception("First name cannot be empty.");
            }
            return new Name(firstName, lastName);
        }
        #endregion

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
