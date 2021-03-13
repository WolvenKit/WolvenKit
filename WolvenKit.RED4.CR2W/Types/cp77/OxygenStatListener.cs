using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OxygenStatListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("ownerPuppet")] public wCHandle<PlayerPuppet> OwnerPuppet { get; set; }
		[Ordinal(1)] [RED("oxygenVfxBlackboard")] public CHandle<worldEffectBlackboard> OxygenVfxBlackboard { get; set; }

		public OxygenStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
