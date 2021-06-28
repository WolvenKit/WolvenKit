using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questOverrideSplineSpeed_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CFloat _speed;
		private CFloat _adjustTime;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(2)] 
		[RED("adjustTime")] 
		public CFloat AdjustTime
		{
			get => GetProperty(ref _adjustTime);
			set => SetProperty(ref _adjustTime, value);
		}

		public questOverrideSplineSpeed_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
