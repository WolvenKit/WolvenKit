using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldRelativeNodePathElement : CVariable
	{
		[Ordinal(0)]  [RED("nodeID")] public CUInt64 NodeID { get; set; }
		[Ordinal(1)]  [RED("prefab")] public CString Prefab { get; set; }

		public worldRelativeNodePathElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
