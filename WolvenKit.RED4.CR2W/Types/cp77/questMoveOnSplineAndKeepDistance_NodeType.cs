using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSplineAndKeepDistance_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private gameEntityReference _keepDistanceFromRef;
		private NodeRef _splineRef;
		private CFloat _distance;
		private CFloat _blendTime;
		private CFloat _minSpeed;
		private CBool _reduceSpeedOnTurns;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("keepDistanceFromRef")] 
		public gameEntityReference KeepDistanceFromRef
		{
			get => GetProperty(ref _keepDistanceFromRef);
			set => SetProperty(ref _keepDistanceFromRef, value);
		}

		[Ordinal(2)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(4)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		[Ordinal(5)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(6)] 
		[RED("reduceSpeedOnTurns")] 
		public CBool ReduceSpeedOnTurns
		{
			get => GetProperty(ref _reduceSpeedOnTurns);
			set => SetProperty(ref _reduceSpeedOnTurns, value);
		}

		public questMoveOnSplineAndKeepDistance_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
