using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WindowBlinders : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SimpleDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_SimpleDevice>>(value);
		}

		[Ordinal(98)] 
		[RED("workspotSideName")] 
		public CName WorkspotSideName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(99)] 
		[RED("portalLight")] 
		public CHandle<gameLightComponent> PortalLight
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(100)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(101)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>(value);
		}

		public WindowBlinders()
		{
			ControllerTypeName = "WindowBlindersController";
			SideTriggerNames = new();
			TriggerComponents = new();
		}
	}
}
