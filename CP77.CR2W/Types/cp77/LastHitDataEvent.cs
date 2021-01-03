using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LastHitDataEvent : redEvent
	{
		[Ordinal(0)]  [RED("hitReactionBehaviorData")] public CHandle<HitReactionBehaviorData> HitReactionBehaviorData { get; set; }

		public LastHitDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
