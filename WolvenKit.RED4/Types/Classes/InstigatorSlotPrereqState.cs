using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InstigatorSlotPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("instigator")] 
		public CWeakHandle<gameweaponObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		public InstigatorSlotPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
