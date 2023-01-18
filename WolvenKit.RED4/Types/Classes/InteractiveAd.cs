using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveAd : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(95)] 
		[RED("triggerExitComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerExitComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(96)] 
		[RED("aduiComponent")] 
		public CHandle<WorldWidgetComponent> AduiComponent
		{
			get => GetPropertyValue<CHandle<WorldWidgetComponent>>();
			set => SetPropertyValue<CHandle<WorldWidgetComponent>>(value);
		}

		[Ordinal(97)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(98)] 
		[RED("showVendor")] 
		public CBool ShowVendor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InteractiveAd()
		{
			ControllerTypeName = "InteractiveAdController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
