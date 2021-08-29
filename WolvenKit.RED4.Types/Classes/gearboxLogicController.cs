using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gearboxLogicController : IVehicleModuleController
	{
		private inkImageWidgetReference _gearboxRImageWidget;
		private inkImageWidgetReference _gearboxNImageWidget;
		private inkImageWidgetReference _gearboxDImageWidget;
		private CHandle<redCallbackObject> _gearboxBBConnectionId;
		private CWeakHandle<gameIBlackboard> _vehBB;

		[Ordinal(1)] 
		[RED("gearboxRImageWidget")] 
		public inkImageWidgetReference GearboxRImageWidget
		{
			get => GetProperty(ref _gearboxRImageWidget);
			set => SetProperty(ref _gearboxRImageWidget, value);
		}

		[Ordinal(2)] 
		[RED("gearboxNImageWidget")] 
		public inkImageWidgetReference GearboxNImageWidget
		{
			get => GetProperty(ref _gearboxNImageWidget);
			set => SetProperty(ref _gearboxNImageWidget, value);
		}

		[Ordinal(3)] 
		[RED("gearboxDImageWidget")] 
		public inkImageWidgetReference GearboxDImageWidget
		{
			get => GetProperty(ref _gearboxDImageWidget);
			set => SetProperty(ref _gearboxDImageWidget, value);
		}

		[Ordinal(4)] 
		[RED("gearboxBBConnectionId")] 
		public CHandle<redCallbackObject> GearboxBBConnectionId
		{
			get => GetProperty(ref _gearboxBBConnectionId);
			set => SetProperty(ref _gearboxBBConnectionId, value);
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public CWeakHandle<gameIBlackboard> VehBB
		{
			get => GetProperty(ref _vehBB);
			set => SetProperty(ref _vehBB, value);
		}
	}
}
