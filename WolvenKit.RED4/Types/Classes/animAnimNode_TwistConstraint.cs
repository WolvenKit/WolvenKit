using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TwistConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("frontAxis")] 
		public CEnum<animAxis> FrontAxis
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		[Ordinal(13)] 
		[RED("transformA")] 
		public animTransformIndex TransformA
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("transformB")] 
		public animTransformIndex TransformB
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(15)] 
		[RED("outputs")] 
		public CArray<animTwistOutput> Outputs
		{
			get => GetPropertyValue<CArray<animTwistOutput>>();
			set => SetPropertyValue<CArray<animTwistOutput>>(value);
		}

		[Ordinal(16)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_TwistConstraint()
		{
			Id = 4294967295;
			InputLink = new();
			TransformA = new();
			TransformB = new();
			Outputs = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
