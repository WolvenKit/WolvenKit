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
			Id = 4294967295;
			InputLink = new();
			WeightNode = new();
			Transforms = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
