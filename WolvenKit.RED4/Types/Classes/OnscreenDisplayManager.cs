using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnscreenDisplayManager : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("contentText")] 
		public inkTextWidgetReference ContentText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public OnscreenDisplayManager()
		{
			ContentText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
