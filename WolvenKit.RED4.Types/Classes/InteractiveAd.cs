using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveAd : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("triggerExitComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerExitComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("aduiComponent")] 
		public CHandle<WorldWidgetComponent> AduiComponent
		{
			get => GetPropertyValue<CHandle<WorldWidgetComponent>>();
			set => SetPropertyValue<CHandle<WorldWidgetComponent>>(value);
		}

		[Ordinal(100)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(101)] 
		[RED("showVendor")] 
		public CBool ShowVendor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InteractiveAd()
		{
			ControllerTypeName = "InteractiveAdController";
		}
	}
}
