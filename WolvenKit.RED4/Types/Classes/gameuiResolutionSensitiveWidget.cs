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

		[Ordinal(1)] 
		[RED("marginToScalecorrectOverride")] 
		public inkMargin MarginToScalecorrectOverride
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		public gameuiResolutionSensitiveWidget()
		{
			Widget = new inkWidgetReference();
			MarginToScalecorrectOverride = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
