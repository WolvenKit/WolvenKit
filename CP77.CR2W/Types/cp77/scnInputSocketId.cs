using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnInputSocketId : CVariable
	{
		[Ordinal(0)]  [RED("isockStamp")] public scnInputSocketStamp IsockStamp { get; set; }
		[Ordinal(1)]  [RED("nodeId")] public scnNodeId NodeId { get; set; }

		public scnInputSocketId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
