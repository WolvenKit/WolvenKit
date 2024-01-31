using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SwitchVehicleVisualCustomizationStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("on")] 
		public CBool On
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("noVFX")] 
		public CBool NoVFX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SwitchVehicleVisualCustomizationStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
