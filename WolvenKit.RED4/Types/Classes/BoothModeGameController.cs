using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BoothModeGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("buttonRef")] 
		public inkWidgetReference ButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public BoothModeGameController()
		{
			ButtonRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
