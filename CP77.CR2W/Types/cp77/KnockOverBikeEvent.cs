using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class KnockOverBikeEvent : redEvent
	{
		[Ordinal(0)]  [RED("applyDirectionalForce")] public CBool ApplyDirectionalForce { get; set; }
		[Ordinal(1)]  [RED("forceKnockdown")] public CBool ForceKnockdown { get; set; }

		public KnockOverBikeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
