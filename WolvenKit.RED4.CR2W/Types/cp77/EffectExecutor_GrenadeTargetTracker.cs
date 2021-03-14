using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_GrenadeTargetTracker : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("potentialTargetSlots")] public CArray<CName> PotentialTargetSlots { get; set; }

		public EffectExecutor_GrenadeTargetTracker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
