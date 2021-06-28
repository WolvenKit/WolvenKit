using System.IO;using System.Runtime.Serialization;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta()]
    [DataContract(Namespace = "")]
    public class CMatrix : CMatrix_
    {
		public CMatrix(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }
    }
}
