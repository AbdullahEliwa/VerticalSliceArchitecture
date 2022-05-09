using VSA.Core.Entities.Base;
using VSA.Core.Shared;
using VSA.Core.Shared.ValueObjects;

namespace VSA.Core.Entities.BookAggregate
{
    public class Author : AuditableEntity<Guid>
    {
        public DescriptionLocalized Name { get; set; }
        public byte Age { get; set; }

        public Gender Gender { get; set; }
    }
}