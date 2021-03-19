using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStopVehicle_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CFloat _time;
		private CBool _detachFromSpline;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(2)] 
		[RED("detachFromSpline")] 
		public CBool DetachFromSpline
		{
			get => GetProperty(ref _detachFromSpline);
			set => SetProperty(ref _detachFromSpline, value);
		}

		public questStopVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
