using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatUnconscious : AIAIEvent
	{
		[Ordinal(2)] [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(3)] [RED("threat")] public wCHandle<entEntity> Threat { get; set; }
		[Ordinal(4)] [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(5)] [RED("detected")] public CBool Detected { get; set; }

		public AIThreatUnconscious(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
