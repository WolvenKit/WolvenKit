using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IceMachineInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("buttonContainer")] 
		public inkWidgetReference ButtonContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("soldOutText")] 
		public inkTextWidgetReference SoldOutText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public IceMachineInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
