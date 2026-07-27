using ArquiteturaLimpa.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaLimpa.Domain.Accounts.Entities
{
    public sealed class Student : Entity
    {
        #region Constructors
        public Student(string firstName, string lastName, string email, string password) : base(id: Guid.CreateVersion7())
        {
            FirstName = firstName;
            LastName= lastName;
            Email = email;
            Password = password;
        }
        #endregion
        public string FirstName { get; } = string.Empty;
        public string LastName { get; }= string.Empty;
        public string Email { get; } = string.Empty;
        public string Password { get; } = string.Empty;

    }
}
