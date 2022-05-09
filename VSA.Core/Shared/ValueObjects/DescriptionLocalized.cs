using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSA.Core.Abstractions;

namespace VSA.Core.Shared.ValueObjects
{
    public class DescriptionLocalized : ValueObject
    {
        public string DescriptionAr { get; }
        public string DescriptionEn { get; }
        public string Description => GetLocalizedPropertyValue(nameof(Description));

        public static implicit operator string(DescriptionLocalized d) => d.Description;
        private DescriptionLocalized() { }
        public DescriptionLocalized(string descriptionAr, string descriptionEn)
        {
            DescriptionAr = descriptionAr;
            DescriptionEn = descriptionEn;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return DescriptionAr;
            yield return DescriptionEn;
        }
    }
}
