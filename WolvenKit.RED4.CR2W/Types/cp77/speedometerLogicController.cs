using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class speedometerLogicController : IVehicleModuleController
	{
		private inkTextWidgetReference _speedTextWidget;
		private CUInt32 _speedBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private wCHandle<vehicleBaseObject> _vehicle;

		[Ordinal(1)] 
		[RED("speedTextWidget")] 
		public inkTextWidgetReference SpeedTextWidget
		{
			get => GetProperty(ref _speedTextWidget);
			set => SetProperty(ref _speedTextWidget, value);
		}

		[Ordinal(2)] 
		[RED("speedBBConnectionId")] 
		public CUInt32 SpeedBBConnectionId
		{
			get => GetProperty(ref _speedBBConnectionId);
			set => SetProperty(ref _speedBBConnectionId, value);
		}

		[Ordinal(3)] 
		[RED("vehBB")] 
		public wCHandle<gameIBlackboard> VehBB
		{
			get => GetProperty(ref _vehBB);
			set => SetProperty(ref _vehBB, value);
		}

		[Ordinal(4)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		public speedometerLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
