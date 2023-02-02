using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RetractableAd : BaseAnimatedDevice
	{
		[Ordinal(99)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(100)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(101)] 
		[RED("advUiComponent")] 
		public CHandle<entIComponent> AdvUiComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(102)] 
		[RED("isPartOfTheTrap")] 
		public CBool IsPartOfTheTrap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RetractableAd()
		{
			ControllerTypeName = "RetractableAdController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
