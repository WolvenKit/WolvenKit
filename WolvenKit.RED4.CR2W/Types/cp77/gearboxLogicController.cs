using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gearboxLogicController : IVehicleModuleController
	{
		private inkImageWidgetReference _gearboxRImageWidget;
		private inkImageWidgetReference _gearboxNImageWidget;
		private inkImageWidgetReference _gearboxDImageWidget;
		private CUInt32 _gearboxBBConnectionId;
		private wCHandle<gameIBlackboard> _vehBB;

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
		public CUInt32 GearboxBBConnectionId
		{
			get => GetProperty(ref _gearboxBBConnectionId);
			set => SetProperty(ref _gearboxBBConnectionId, value);
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public wCHandle<gameIBlackboard> VehBB
		{
			get => GetProperty(ref _vehBB);
			set => SetProperty(ref _vehBB, value);
		}

		public gearboxLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
