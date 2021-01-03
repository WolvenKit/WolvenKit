using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questControlObject_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }

		public questControlObject_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
