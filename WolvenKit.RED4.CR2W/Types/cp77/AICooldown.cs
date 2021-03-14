using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICooldown : AITimeCondition
	{
		[Ordinal(0)] [RED("cooldown")] public CFloat Cooldown { get; set; }
		[Ordinal(1)] [RED("timestamp")] public CFloat Timestamp { get; set; }

		public AICooldown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
