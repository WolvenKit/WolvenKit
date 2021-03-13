using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KnockOverBikeEvent : redEvent
	{
		[Ordinal(0)] [RED("forceKnockdown")] public CBool ForceKnockdown { get; set; }
		[Ordinal(1)] [RED("applyDirectionalForce")] public CBool ApplyDirectionalForce { get; set; }

		public KnockOverBikeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
