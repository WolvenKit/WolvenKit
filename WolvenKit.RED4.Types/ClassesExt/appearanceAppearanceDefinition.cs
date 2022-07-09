using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.RED4.Types
{
    public partial class appearanceAppearanceDefinition
    {
        [RED("components")]
        [REDProperty(IsIgnored = true)]
        public CArray<entIComponent> Components
        {
            get => GetPropertyValue<CArray<entIComponent>>();
            set => SetPropertyValue<CArray<entIComponent>>(value);
        }
    }
}
