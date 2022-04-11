using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMoveOnSpline_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("startFrom")] 
		public CFloat StartFrom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("blendType")] 
		public CEnum<vehiclePlayerToAIInterpolationType> BlendType
		{
			get => GetPropertyValue<CEnum<vehiclePlayerToAIInterpolationType>>();
			set => SetPropertyValue<CEnum<vehiclePlayerToAIInterpolationType>>(value);
		}

		[Ordinal(4)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("reverseGear")] 
		public CBool ReverseGear
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("arriveWithPivot")] 
		public CBool ArriveWithPivot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("sceneBlendInDistance")] 
		public CFloat SceneBlendInDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("sceneBlendOutDistance")] 
		public CFloat SceneBlendOutDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("overrides")] 
		public CHandle<questIVehicleMoveOnSpline_Overrides> Overrides
		{
			get => GetPropertyValue<CHandle<questIVehicleMoveOnSpline_Overrides>>();
			set => SetPropertyValue<CHandle<questIVehicleMoveOnSpline_Overrides>>(value);
		}

		[Ordinal(10)] 
		[RED("audioCurves")] 
		public CResourceReference<vehicleAudioVehicleCurveSet> AudioCurves
		{
			get => GetPropertyValue<CResourceReference<vehicleAudioVehicleCurveSet>>();
			set => SetPropertyValue<CResourceReference<vehicleAudioVehicleCurveSet>>(value);
		}

		public questMoveOnSpline_NodeType()
		{
			VehicleRef = new() { Names = new() };
			BlendTime = 1.000000F;
			SceneBlendInDistance = 15.000000F;
			SceneBlendOutDistance = 15.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
