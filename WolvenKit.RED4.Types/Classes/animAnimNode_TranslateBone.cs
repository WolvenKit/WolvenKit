using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TranslateBone : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(12)] 
		[RED("inputTranslation")] 
		public animVectorLink InputTranslation
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(13)] 
		[RED("scale")] 
		public Vector4 Scale
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(14)] 
		[RED("biasValue")] 
		public Vector4 BiasValue
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(15)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(16)] 
		[RED("useIncrementalMode")] 
		public CBool UseIncrementalMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_TranslateBone()
		{
			Id = 4294967295;
			InputNode = new();
			InputTranslation = new();
			Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F };
			BiasValue = new();
			Bone = new();
			ResetOnActivation = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
