using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LookAt : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("forwardAxis")] 
		public CEnum<animAxis> ForwardAxis
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		[Ordinal(14)] 
		[RED("useLimits")] 
		public CBool UseLimits
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("limitAxis")] 
		public CEnum<animAxis> LimitAxis
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		[Ordinal(16)] 
		[RED("limitAngle")] 
		public CFloat LimitAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("targetNode")] 
		public animVectorLink TargetNode
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(18)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_LookAt()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			Transform = new animTransformIndex();
			LimitAngle = 90.000000F;
			TargetNode = new animVectorLink();
			WeightNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
