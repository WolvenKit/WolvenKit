using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_GrenadeTargetTracker : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("potentialTargetSlots")] public CArray<CName> PotentialTargetSlots { get; set; }

		public EffectExecutor_GrenadeTargetTracker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
