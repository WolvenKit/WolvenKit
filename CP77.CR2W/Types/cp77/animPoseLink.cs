using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoseLink : CVariable
	{
		[Ordinal(0)]  [RED("node")] public wCHandle<animAnimNode_Base> Node { get; set; }

		public animPoseLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
