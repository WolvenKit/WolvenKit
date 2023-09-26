using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiResolutionSensitiveWidget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public inkWidgetReference Widget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiResolutionSensitiveWidget()
		{
			Widget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
