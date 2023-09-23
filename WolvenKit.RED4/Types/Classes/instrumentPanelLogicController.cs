using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class instrumentPanelLogicController : IVehicleModuleController
	{
		[Ordinal(1)] 
		[RED("lightStateImageWidget")] 
		public inkImageWidgetReference LightStateImageWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("cautionStateImageWidget")] 
		public inkImageWidgetReference CautionStateImageWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("lightStateBBConnectionId")] 
		public CHandle<redCallbackObject> LightStateBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("cautionStateBBConnectionId")] 
		public CHandle<redCallbackObject> CautionStateBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public CWeakHandle<gameIBlackboard> VehBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public instrumentPanelLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
