using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MaskReset : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(13)] 
		[RED("transforms")] 
		public CArray<animTransformIndex> Transforms
		{
			get => GetPropertyValue<CArray<animTransformIndex>>();
			set => SetPropertyValue<CArray<animTransformIndex>>(value);
		}

		public animAnimNode_MaskReset()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			WeightNode = new animFloatLink();
			Transforms = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
