using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IceMachineInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("buttonContainer")] 
		public inkWidgetReference ButtonContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public IceMachineInkGameController()
		{
			ButtonContainer = new();
		}
	}
}
