using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiteturaLimpa.Domain.Shared.Entities
{
    public abstract class Entity(Guid id) : IEquatable<Guid>
    {
        #region Properties

        public Guid Id { get;  } = id;

        #region Equatable Implementaiton
        public bool Equals(Guid id) => Id == id;

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        #endregion
    }
}
