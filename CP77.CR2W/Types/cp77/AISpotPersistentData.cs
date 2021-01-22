using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AISpotPersistentData : CVariable
	{
		[Ordinal(0)]  [RED("globalNodeId")] public worldGlobalNodeID GlobalNodeId { get; set; }
		[Ordinal(1)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(2)]  [RED("worldTransform")] public WorldTransform WorldTransform { get; set; }

		public AISpotPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
