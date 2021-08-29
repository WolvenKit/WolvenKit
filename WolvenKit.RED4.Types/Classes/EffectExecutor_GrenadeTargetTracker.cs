using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_GrenadeTargetTracker : gameEffectExecutor_Scripted
	{
		private CArray<CName> _potentialTargetSlots;

		[Ordinal(1)] 
		[RED("potentialTargetSlots")] 
		public CArray<CName> PotentialTargetSlots
		{
			get => GetProperty(ref _potentialTargetSlots);
			set => SetProperty(ref _potentialTargetSlots, value);
		}
	}
}
