using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIThreatDeath : AIAIEvent
	{
		[Ordinal(0)]  [RED("detected")] public CBool Detected { get; set; }
		[Ordinal(1)]  [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(2)]  [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(3)]  [RED("threat")] public wCHandle<entEntity> Threat { get; set; }

		public AIThreatDeath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
