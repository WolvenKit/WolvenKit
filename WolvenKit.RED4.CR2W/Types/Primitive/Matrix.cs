using System.IO;using System.Runtime.Serialization;
using WolvenKit.RED4.CR2W.Reflection;
using static WolvenKit.RED4.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta()]
    [DataContract(Namespace = "")]
    public class CMatrix : CMatrix_
    {
		public CMatrix(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }
    }
}
