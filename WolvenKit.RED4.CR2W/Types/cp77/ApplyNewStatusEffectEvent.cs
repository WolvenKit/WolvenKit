using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyNewStatusEffectEvent : redEvent
	{
		[Ordinal(0)] [RED("effectID")] public TweakDBID EffectID { get; set; }
		[Ordinal(1)] [RED("instigatorID")] public TweakDBID InstigatorID { get; set; }

		public ApplyNewStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
