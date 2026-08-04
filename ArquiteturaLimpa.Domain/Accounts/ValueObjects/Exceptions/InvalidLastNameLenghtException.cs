using ArquiteturaLimpa.Domain.Shared.Exceptions;

namespace ArquiteturaLimpa.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidLastNameLenghtException(string message = "First name should have between {0} and {1}") : DomainException(message);
}
