using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleRadioLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("isSoundStopped")] 
		public CBool IsSoundStopped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleRadioLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
