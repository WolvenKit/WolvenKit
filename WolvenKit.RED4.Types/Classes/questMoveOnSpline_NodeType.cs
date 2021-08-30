using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMoveOnSpline_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private NodeRef _splineRef;
		private CFloat _startFrom;
		private CEnum<vehiclePlayerToAIInterpolationType> _blendType;
		private CFloat _blendTime;
		private CBool _reverseGear;
		private CBool _arriveWithPivot;
		private CFloat _sceneBlendInDistance;
		private CFloat _sceneBlendOutDistance;
		private CHandle<questIVehicleMoveOnSpline_Overrides> _overrides;
		private CResourceReference<vehicleAudioVehicleCurveSet> _audioCurves;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}

		[Ordinal(2)] 
		[RED("startFrom")] 
		public CFloat StartFrom
		{
			get => GetProperty(ref _startFrom);
			set => SetProperty(ref _startFrom, value);
		}

		[Ordinal(3)] 
		[RED("blendType")] 
		public CEnum<vehiclePlayerToAIInterpolationType> BlendType
		{
			get => GetProperty(ref _blendType);
			set => SetProperty(ref _blendType, value);
		}

		[Ordinal(4)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		[Ordinal(5)] 
		[RED("reverseGear")] 
		public CBool ReverseGear
		{
			get => GetProperty(ref _reverseGear);
			set => SetProperty(ref _reverseGear, value);
		}

		[Ordinal(6)] 
		[RED("arriveWithPivot")] 
		public CBool ArriveWithPivot
		{
			get => GetProperty(ref _arriveWithPivot);
			set => SetProperty(ref _arriveWithPivot, value);
		}

		[Ordinal(7)] 
		[RED("sceneBlendInDistance")] 
		public CFloat SceneBlendInDistance
		{
			get => GetProperty(ref _sceneBlendInDistance);
			set => SetProperty(ref _sceneBlendInDistance, value);
		}

		[Ordinal(8)] 
		[RED("sceneBlendOutDistance")] 
		public CFloat SceneBlendOutDistance
		{
			get => GetProperty(ref _sceneBlendOutDistance);
			set => SetProperty(ref _sceneBlendOutDistance, value);
		}

		[Ordinal(9)] 
		[RED("overrides")] 
		public CHandle<questIVehicleMoveOnSpline_Overrides> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		[Ordinal(10)] 
		[RED("audioCurves")] 
		public CResourceReference<vehicleAudioVehicleCurveSet> AudioCurves
		{
			get => GetProperty(ref _audioCurves);
			set => SetProperty(ref _audioCurves, value);
		}

		public questMoveOnSpline_NodeType()
		{
			_blendTime = 1.000000F;
			_sceneBlendInDistance = 15.000000F;
			_sceneBlendOutDistance = 15.000000F;
		}
	}
}
