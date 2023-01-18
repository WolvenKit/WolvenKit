using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TransformRotator : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("axis")] 
		public Vector3 Axis
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(14)] 
		[RED("valueScale")] 
		public CFloat ValueScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("clamp")] 
		public CBool Clamp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("angleMin")] 
		public CFloat AngleMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("angleMax")] 
		public CFloat AngleMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("angleValueNode")] 
		public animFloatLink AngleValueNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(19)] 
		[RED("angleSpeedNode")] 
		public animFloatLink AngleSpeedNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_TransformRotator()
		{
			Id = 4294967295;
			InputLink = new();
			Transform = new();
			Axis = new() { Z = 1.000000F };
			ValueScale = 1.000000F;
			AngleMin = -180.000000F;
			AngleMax = 180.000000F;
			AngleValueNode = new();
			AngleSpeedNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
