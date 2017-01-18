using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W
{
    public interface ILocalizedStringSource
    {
        string GetLocalizedString(uint val);
    }
}
