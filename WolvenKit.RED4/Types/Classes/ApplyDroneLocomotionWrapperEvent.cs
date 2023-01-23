using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyDroneLocomotionWrapperEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("movementType")] 
		public CName MovementType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ApplyDroneLocomotionWrapperEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
