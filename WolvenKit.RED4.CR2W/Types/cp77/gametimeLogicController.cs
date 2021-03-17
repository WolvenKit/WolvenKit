using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gametimeLogicController : IVehicleModuleController
	{
		private inkTextWidgetReference _gametimeTextWidget;
		private CUInt32 _gametimeBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;
		private wCHandle<vehicleBaseObject> _vehicle;
		private wCHandle<vehicleUIGameController> _parent;

		[Ordinal(1)] 
		[RED("gametimeTextWidget")] 
		public inkTextWidgetReference GametimeTextWidget
		{
			get => GetProperty(ref _gametimeTextWidget);
			set => SetProperty(ref _gametimeTextWidget, value);
		}

		[Ordinal(2)] 
		[RED("gametimeBBConnectionId")] 
		public CUInt32 GametimeBBConnectionId
		{
			get => GetProperty(ref _gametimeBBConnectionId);
			set => SetProperty(ref _gametimeBBConnectionId, value);
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

		[Ordinal(5)] 
		[RED("parent")] 
		public wCHandle<vehicleUIGameController> Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}

		public gametimeLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
