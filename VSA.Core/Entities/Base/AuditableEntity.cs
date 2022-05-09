using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSA.Core.Entities.Base
{
    public abstract class AuditableEntity<TKey> : BaseEntity<TKey> where TKey : struct
    {
        public DateTimeOffset Created { get; set; }
        public string CreatedBy { get; set; }

        public DateTimeOffset? LastModified { get; set; }

        public string LastModifiedBy { get; set; }
    }
}
