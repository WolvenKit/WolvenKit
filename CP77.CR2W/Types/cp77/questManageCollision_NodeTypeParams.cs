using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questManageCollision_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("components")] public CArray<CName> Components { get; set; }
		[Ordinal(1)]  [RED("enableCollision")] public CBool EnableCollision { get; set; }
		[Ordinal(2)]  [RED("enableQueries")] public CBool EnableQueries { get; set; }
		[Ordinal(3)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }

		public questManageCollision_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
