using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeDeflectAttackEvents : MeleeAttackGenericEvents
	{
		[Ordinal(8)] [RED("slowMoSet")] public CBool SlowMoSet { get; set; }

		public MeleeDeflectAttackEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
