using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIThreatDeath : AIAIEvent
	{
		[Ordinal(2)] [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(3)] [RED("threat")] public wCHandle<entEntity> Threat { get; set; }
		[Ordinal(4)] [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(5)] [RED("detected")] public CBool Detected { get; set; }

		public AIThreatDeath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
