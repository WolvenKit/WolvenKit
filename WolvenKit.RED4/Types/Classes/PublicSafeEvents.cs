using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PublicSafeEvents : WeaponEventsTransition
	{
		[Ordinal(6)] 
		[RED("weaponUnequipRequestSent")] 
		public CBool WeaponUnequipRequestSent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PublicSafeEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
