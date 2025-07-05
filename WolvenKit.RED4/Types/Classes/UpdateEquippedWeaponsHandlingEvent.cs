using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateEquippedWeaponsHandlingEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("currentStaminaValue")] 
		public CFloat CurrentStaminaValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public UpdateEquippedWeaponsHandlingEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
