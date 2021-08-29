using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gametimeLogicController : IVehicleModuleController
	{
		private inkTextWidgetReference _gametimeTextWidget;
		private CHandle<redCallbackObject> _gametimeBBConnectionId;
		private CWeakHandle<gameIBlackboard> _vehBB;
		private CWeakHandle<vehicleBaseObject> _vehicle;
		private CWeakHandle<vehicleUIGameController> _parent;

		[Ordinal(1)] 
		[RED("gametimeTextWidget")] 
		public inkTextWidgetReference GametimeTextWidget
		{
			get => GetProperty(ref _gametimeTextWidget);
			set => SetProperty(ref _gametimeTextWidget, value);
		}

		[Ordinal(2)] 
		[RED("gametimeBBConnectionId")] 
		public CHandle<redCallbackObject> GametimeBBConnectionId
		{
			get => GetProperty(ref _gametimeBBConnectionId);
			set => SetProperty(ref _gametimeBBConnectionId, value);
		}

		[Ordinal(3)] 
		[RED("vehBB")] 
		public CWeakHandle<gameIBlackboard> VehBB
		{
			get => GetProperty(ref _vehBB);
			set => SetProperty(ref _vehBB, value);
		}

		[Ordinal(4)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(5)] 
		[RED("parent")] 
		public CWeakHandle<vehicleUIGameController> Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}
	}
}
