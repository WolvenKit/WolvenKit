using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TwistConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("frontAxis")] 
		public CEnum<animAxis> FrontAxis
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		[Ordinal(3)] 
		[RED("transformA")] 
		public animTransformIndex TransformA
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("transformB")] 
		public animTransformIndex TransformB
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(5)] 
		[RED("outputs")] 
		public CArray<animTwistOutput> Outputs
		{
			get => GetPropertyValue<CArray<animTwistOutput>>();
			set => SetPropertyValue<CArray<animTwistOutput>>(value);
		}

		[Ordinal(6)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_TwistConstraint()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			TransformA = new animTransformIndex();
			TransformB = new animTransformIndex();
			Outputs = new() { new animTwistOutput() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
