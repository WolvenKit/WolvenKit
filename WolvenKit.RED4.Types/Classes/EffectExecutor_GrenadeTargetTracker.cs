using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_GrenadeTargetTracker : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("potentialTargetSlots")] 
		public CArray<CName> PotentialTargetSlots
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public EffectExecutor_GrenadeTargetTracker()
		{
			PotentialTargetSlots = new();
		}
	}
}
