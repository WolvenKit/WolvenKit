using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AdditionalTransform : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("additionalTransforms")] 
		public animAdditionalTransformContainer AdditionalTransforms
		{
			get => GetPropertyValue<animAdditionalTransformContainer>();
			set => SetPropertyValue<animAdditionalTransformContainer>(value);
		}

		public animAnimNode_AdditionalTransform()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			AdditionalTransforms = new animAdditionalTransformContainer();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
