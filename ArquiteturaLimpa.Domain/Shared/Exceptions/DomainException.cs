using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaLimpa.Domain.Shared.Exceptions
{
    public abstract class DomainException(string message) : Exception(message);
}
