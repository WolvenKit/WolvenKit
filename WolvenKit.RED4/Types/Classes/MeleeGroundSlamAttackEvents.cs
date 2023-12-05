using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeGroundSlamAttackEvents : MeleeAttackGenericEvents
	{
		[Ordinal(15)] 
		[RED("knockdownImmunityModifier")] 
		public CHandle<gameStatModifierData_Deprecated> KnockdownImmunityModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(16)] 
		[RED("stunImmunityModifier")] 
		public CHandle<gameStatModifierData_Deprecated> StunImmunityModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public MeleeGroundSlamAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
