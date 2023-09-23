using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WindowBlinders : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SimpleDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_SimpleDevice>>(value);
		}

		[Ordinal(99)] 
		[RED("workspotSideName")] 
		public CName WorkspotSideName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(100)] 
		[RED("portalLight")] 
		public CHandle<gameLightComponent> PortalLight
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(101)] 
		[RED("portalLight2")] 
		public CHandle<gameLightComponent> PortalLight2
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(102)] 
		[RED("portalLight3")] 
		public CHandle<gameLightComponent> PortalLight3
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(103)] 
		[RED("portalLight4")] 
		public CHandle<gameLightComponent> PortalLight4
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(104)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(105)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameStaticTriggerAreaComponent>>>(value);
		}

		[Ordinal(106)] 
		[RED("interactionBlockingCollider")] 
		public CHandle<entIPlacedComponent> InteractionBlockingCollider
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		public WindowBlinders()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
