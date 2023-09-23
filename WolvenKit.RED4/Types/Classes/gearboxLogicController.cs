using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gearboxLogicController : IVehicleModuleController
	{
		[Ordinal(1)] 
		[RED("gearboxRImageWidget")] 
		public inkImageWidgetReference GearboxRImageWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("gearboxNImageWidget")] 
		public inkImageWidgetReference GearboxNImageWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("gearboxDImageWidget")] 
		public inkImageWidgetReference GearboxDImageWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("gearboxBBConnectionId")] 
		public CHandle<redCallbackObject> GearboxBBConnectionId
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

		public gearboxLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
