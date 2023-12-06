using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeChargedHoldEvents : MeleeRumblingEvents
	{
		[Ordinal(2)] 
		[RED("clearWeaponCharge")] 
		public CBool ClearWeaponCharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("effectiveRangeMod")] 
		public CHandle<gameStatModifierData_Deprecated> EffectiveRangeMod
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public MeleeChargedHoldEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
