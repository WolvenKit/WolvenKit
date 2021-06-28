using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_GrenadeTargetTracker : gameEffectExecutor_Scripted
	{
		private CArray<CName> _potentialTargetSlots;

		[Ordinal(1)] 
		[RED("potentialTargetSlots")] 
		public CArray<CName> PotentialTargetSlots
		{
			get => GetProperty(ref _potentialTargetSlots);
			set => SetProperty(ref _potentialTargetSlots, value);
		}

		public EffectExecutor_GrenadeTargetTracker(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
