using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSA.Core.Entities.Base;
using VSA.Core.Shared.ValueObjects;

namespace VSA.Core.Entities.BookAggregate
{
    public class Book : AuditableEntity<Guid>
    {
        public DescriptionLocalized Title { get; set; }
        public string ImagePath { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }

        public DateTimeOffset PublishDate { get; set; }
    }
}
